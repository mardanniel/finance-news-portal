using FinanceNewsPortal.API.DTO;
using FinanceNewsPortal.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
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

        public AuthController(IConfiguration configuration,
                                UserManager<ApplicationUser> userManager,
                                SignInManager<ApplicationUser> signInManager)
        {
            this._configuration = configuration;
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDTO loginUserDTO)
        {
            if (ModelState.IsValid)
            {
                var loginResult = await _signInManager.PasswordSignInAsync(loginUserDTO.Username,
                                                                        loginUserDTO.Password,
                                                                        loginUserDTO.RememberMe,
                                                                        false);
                if (loginResult.Succeeded)
                {
                    var user = await this._userManager.FindByEmailAsync(loginUserDTO.Username);
                    if (user != null)
                    {
                        var issuer = this._configuration.GetValue<string>("JWT:Issuer");
                        var audience = this._configuration.GetValue<string>("JWT:Audience");
                        var key = this._configuration.GetValue<string>("JWT:Key");
                        var expiry = this._configuration.GetValue<int>("JWT:ExpiryInMinutes");

                        var keyBytes = Encoding.UTF8.GetBytes(key);
                        var theKey = new SymmetricSecurityKey(keyBytes);
                        var creds = new SigningCredentials(theKey, SecurityAlgorithms.HmacSha256);
                        var token = new JwtSecurityToken(issuer, audience, null, expires: DateTime.Now.AddMinutes(expiry), signingCredentials: creds);
                        return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
                    }
                }
            }
            
            return BadRequest(ModelState);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDTO registerUserDTO)
        {
            if(ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = registerUserDTO.FirstName,
                    LastName = registerUserDTO.LastName,
                    Email = registerUserDTO.Email,
                    Gender = registerUserDTO.Gender,
                };

                var registerResult = await this._userManager.CreateAsync(user, registerUserDTO.Password);
                if (registerResult.Succeeded)
                {
                    return Ok();
                }
            }

            return BadRequest(ModelState);
        }

        [HttpPost("LogOut")]
        public async Task<IActionResult> LogOut()
        {
            return Ok();
        }
    }
}
