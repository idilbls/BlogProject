using BlogProject.API.Models;
using LibraryProject.Models.EntityFrameworkCore.Context;

namespace LibraryProject.Services
{
    public class ProfileService : IProfileService
    {
        protected readonly BlogDbContext _context;

        public ProfileService(BlogDbContext context)
        {
            _context = context;
        }
        public async Task<Profile> AddAsync(Profile profile)
        {
            await _context.Profiles.AddAsync(profile);
            await _context.SaveChangesAsync();
            return profile;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var result = await _context.Profiles.FindAsync(id);
            _context.Profiles.Remove(result);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IList<Profile>> GetAllAsync()
        {
            var list = _context.Profiles.ToList();
            return await Task.FromResult(list);
        }

        public async Task<Profile> GetByIdAsync(int id)
        {
            var profile = await _context.Profiles.FindAsync(id);
            return profile;
        }

        public async Task<Profile> UpdateAsync(Profile profile)
        {
            var result = await _context.Profiles.FindAsync(profile.Id);

            result.PhotoBase64 = profile.PhotoBase64;
            result.Name = profile.Name;
            result.BirthDate = profile.BirthDate;
            result.Info = profile.Info;
            result.Email = profile.Email;

            _context.Profiles.Update(result);
            await _context.SaveChangesAsync();
            return result;
        }
    }
}
