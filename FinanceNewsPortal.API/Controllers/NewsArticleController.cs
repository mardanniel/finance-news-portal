using FinanceNewsPortal.API.DTO;
using FinanceNewsPortal.API.Enums;
using FinanceNewsPortal.API.Helper;
using FinanceNewsPortal.API.Models;
using FinanceNewsPortal.API.Repository.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinanceNewsPortal.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class NewsArticleController : ControllerBase
    {
        private readonly INewsArticlesRepository _newsArticlesRepository;
        private readonly IUserRepository _userRepository;
        private readonly FileUpload _fileUpload;

        public NewsArticleController(INewsArticlesRepository newsArticlesRepository,
                                        IUserRepository userRepository,
                                        FileUpload fileUpload)
        {
            this._newsArticlesRepository = newsArticlesRepository;
            this._userRepository = userRepository;
            this._fileUpload = fileUpload;
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetNewsArticles([FromQuery] int? pageNumber, [FromQuery] int? pageSize)
        {
            List<NewsArticleWithAuthorDTO> newsArticles = await this._newsArticlesRepository.GetNewsArticles(pageNumber ?? 1, pageSize ?? 10);
            return Ok(newsArticles);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateNewsArticle([FromForm] CreateNewsArticleDTO newsArticleDTO)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApplicationUser user = await this._userRepository.GetCurrentUser();

            NewsArticle newsArticle = new NewsArticle 
            {
                ApplicationUserId = user.Id,
                Title = newsArticleDTO.Title,
                Description = newsArticleDTO.Context,
                Status = NewsStatus.Pending
            };

            if (newsArticleDTO.Image != null)
            {
                string imageName = this._fileUpload.UploadFile(newsArticleDTO.Image, user.Id, "news-image");

                newsArticle.ImageFilePath = imageName;
            }

            await this._newsArticlesRepository.CreateNewsArticle(newsArticle);

            return Ok("News Article created successfully.");
        }

        [HttpGet("{newsArticleId:guid}")]
        public async Task<IActionResult> GetNewsArticle([FromRoute] Guid? newsArticleId)
        {
            if(newsArticleId == null)
            {
                return BadRequest("Provide news article ID.");
            }

            NewsArticle news = await this._newsArticlesRepository.GetNewsArticleById((Guid)newsArticleId);

            if(news == null)
            {
                return NotFound("News article not found.");
            }

            return Ok(news);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateNewsArticle([FromForm] UpdateNewsArticleDTO newsArticleDTO)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApplicationUser user = await this._userRepository.GetCurrentUser();

            var newsArticleToUpdate = await this._newsArticlesRepository.GetNewsArticleById((Guid)newsArticleDTO.Id);

            if(newsArticleToUpdate.Author.Id != user.Id)
            {
                return Unauthorized("Update only applies to the news article owner.");
            }

            await this._newsArticlesRepository.UpdateNewsArticle((Guid)newsArticleDTO.Id, newsArticleDTO);

            return Ok("News Article updated successfully.");
        }

        [HttpDelete("Delete/{newsArticleId:guid}")]
        public async Task<IActionResult> DeleteNewsArticle([FromRoute] Guid? newsArticleId)
        {
            if(newsArticleId == null)
            {
                return BadRequest("Provide news article ID.");
            }

            var news = await this._newsArticlesRepository.GetNewsArticleById((Guid)newsArticleId);

            if (news == null)
            {
                return NotFound("News article not found.");
            }

            await this._newsArticlesRepository.DeleteNewsArticle((Guid)newsArticleId);

            return Ok("News Article deleted successfully.");
        }
    }
}
