using BlogProject.API.Models;
using LibraryProject.Models.EntityFrameworkCore.Context;
using Microsoft.EntityFrameworkCore;

namespace BlogProject.API.Services
{
    public class ArticleService : IArticleService
    {
        protected readonly BlogDbContext _context;

        public ArticleService(BlogDbContext context)
        {
            _context = context;
        }
        public async Task<Article> AddAsync(Article article)
        {
            await _context.Articles.AddAsync(article);
            await _context.SaveChangesAsync();
            return article;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var result = await _context.Articles.FindAsync(id);
            _context.Articles.Remove(result);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IList<Article>> GetAllAsync()
        {
            var list = _context.Articles.Include("Comments").ToList();
            return await Task.FromResult(list);
        }

        public async Task<Article> GetByIdAsync(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            return article;
        }

        public async Task<Article> UpdateAsync(Article article)
        {
            var result = await _context.Articles.FindAsync(article.Id);

            result.Title = article.Title;
            result.Content = article.Content;
            result.Comments = article.Comments;

            _context.Articles.Update(result);
            await _context.SaveChangesAsync();
            return result;
        }
    }
}
