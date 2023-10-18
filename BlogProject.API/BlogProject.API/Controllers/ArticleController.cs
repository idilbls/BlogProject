using BlogProject.API.Models;
using BlogProject.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet("get_all")]
        public async Task<IList<Article>> GetAllArticles()
        {
            return await _articleService.GetAllAsync();
        }

        [HttpGet("get_by_id")]
        public async Task<Article> GetArticleById([FromQuery] int id)
        {
            return await _articleService.GetByIdAsync(id);
        }

        [HttpPost("add")]
        public async Task<Article> AddArticle([FromBody] Article article)
        {
            return await _articleService.AddAsync(article);

        }

        [HttpPost("update")]
        public async Task<Article> UpdateArticle([FromBody] Article article)
        {
            return await _articleService.UpdateAsync(article);
        }

        [HttpDelete("delete")]
        public async Task<bool> DeleteArticle([FromQuery] int id)
        {
            return await _articleService.DeleteAsync(id);
        }
    }
}
