using BlogProject.API.Models;
using BlogProject.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost("add")]
        public async Task<Comment> AddComment([FromBody] Comment comment)
        {
            return await _commentService.AddAsync(comment);

        }

        [HttpDelete("delete")]
        public async Task<bool> DeleteComment([FromQuery] int id)
        {
            return await _commentService.DeleteAsync(id);
        }
    }
}
