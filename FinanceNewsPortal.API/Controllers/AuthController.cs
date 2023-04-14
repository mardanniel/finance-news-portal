using FinanceNewsPortal.API.DTO;
using FinanceNewsPortal.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FinanceNewsPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthController(IConfiguration configuration,
                                UserManager<ApplicationUser> userManager,
                                SignInManager<ApplicationUser> signInManager,
                                RoleManager<IdentityRole> roleManager)
        {
            this._configuration = configuration;
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = roleManager;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDTO loginUserDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var loginResult = await _signInManager.PasswordSignInAsync(loginUserDTO.Username,
                                                                        loginUserDTO.Password,
                                                                        loginUserDTO.RememberMe,
                                                                        false);
            if (!loginResult.Succeeded)
            {
                ModelState.AddModelError(String.Empty, "Invalid login credentials.");
                return BadRequest(ModelState);
            }

            var user = await this._userManager.FindByEmailAsync(loginUserDTO.Username);

            if (user == null)
            {
                return BadRequest("Something went wrong, please try again later");
            }

            var roles = await this._userManager.GetRolesAsync(user);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, loginUserDTO.Username),
                new Claim(ClaimTypes.Role, roles[0])
            };

            var issuer = this._configuration.GetValue<string>("JWT:Issuer");
            var audience = this._configuration.GetValue<string>("JWT:Audience");
            var key = this._configuration.GetValue<string>("JWT:Key");
            var expiry = this._configuration.GetValue<int>("JWT:ExpiryInMinutes");

            var keyBytes = Encoding.UTF8.GetBytes(key);
            var theKey = new SymmetricSecurityKey(keyBytes);
            var creds = new SigningCredentials(theKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(issuer, audience, claims, expires: DateTime.Now.AddMinutes(expiry), signingCredentials: creds);
            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDTO registerUserDTO)
        {
            if(ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser
                {
                    UserName = registerUserDTO.Email,
                    FirstName = registerUserDTO.FirstName,
                    LastName = registerUserDTO.LastName,
                    Email = registerUserDTO.Email,
                    Gender = registerUserDTO.Gender,
                    Status = true
                };

                var registerResult = await this._userManager.CreateAsync(user, registerUserDTO.Password);
                
                if (registerResult.Succeeded)
                {
                    bool roleExist = await this._roleManager.RoleExistsAsync(UserRole.Registered);

                    if (!roleExist)
                    {
                        await this._roleManager.CreateAsync(new IdentityRole(UserRole.Registered));
                    }

                    var roleResult = await this._userManager.AddToRoleAsync(user, UserRole.Registered);

                    if (!roleResult.Succeeded)
                    {
                        ModelState.AddModelError(String.Empty, "User Role cannot be assigned.");
                    }

                    return Ok("User successfully registered");
                }
            }

            return BadRequest(ModelState);
        }
    }
}
