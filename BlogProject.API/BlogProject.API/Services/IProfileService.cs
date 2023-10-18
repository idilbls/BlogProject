using BlogProject.API.Models;

namespace LibraryProject.Services
{
    public interface IProfileService
    {
        Task<IList<Profile>> GetAllAsync();
        Task<Profile> GetByIdAsync(int id);
        Task<Profile> AddAsync(Profile profile);
        Task<Profile> UpdateAsync(Profile profile);
        Task<bool> DeleteAsync(int id);
    }
}
