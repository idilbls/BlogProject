using BlogProject.API.Models;

namespace BlogProject.API.Services
{
    public interface ICommentService
    {
        Task<Comment> AddAsync(Comment comment);
        Task<bool> DeleteAsync(int id);
    }
}
