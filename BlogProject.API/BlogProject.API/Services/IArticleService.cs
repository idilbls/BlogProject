using BlogProject.API.Models;

namespace BlogProject.API.Services
{
    public interface IArticleService
    {
        Task<IList<Article>> GetAllAsync();
        Task<Article> GetByIdAsync(int id);
        Task<Article> AddAsync(Article article);
        Task<Article> UpdateAsync(Article article);
        Task<bool> DeleteAsync(int id);
    }
}
