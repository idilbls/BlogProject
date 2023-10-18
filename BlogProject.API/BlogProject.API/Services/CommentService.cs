using BlogProject.API.Models;
using LibraryProject.Models.EntityFrameworkCore.Context;

namespace BlogProject.API.Services
{
    public class CommentService : ICommentService
    {
        protected readonly BlogDbContext _context;

        public CommentService(BlogDbContext context)
        {
            _context = context;
        }
        public async Task<Comment> AddAsync(Comment comment)
        {
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();
            return comment;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var result = await _context.Comments.FindAsync(id);
            _context.Comments.Remove(result);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
