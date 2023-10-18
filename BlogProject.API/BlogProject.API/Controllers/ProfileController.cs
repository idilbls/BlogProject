using BlogProject.API.Models;
using LibraryProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : Controller
    {
        private readonly IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet("get_all")]
        public async Task<IList<Profile>> GetAllProfiles()
        {
            return await _profileService.GetAllAsync();
        }

        [HttpGet("get_by_id")]

        public async Task<Profile> GetProfileById([FromQuery] int id)
        {
            return await _profileService.GetByIdAsync(id);
        }

        [HttpPost("add")]
        public async Task<Profile> AddProfile([FromBody] Profile profile)
        {
            return await _profileService.AddAsync(profile);

        }

        [HttpPost("update")]
        public async Task<Profile> UpdateProfile([FromBody] Profile profile)
        {
            return await _profileService.UpdateAsync(profile);
        }

        [HttpDelete("delete")]
        public async Task<bool> DeleteProfile([FromQuery] int id)
        {
            return await _profileService.DeleteAsync(id);
        }
    }
}
