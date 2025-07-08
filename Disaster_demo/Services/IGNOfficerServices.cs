using Disaster_demo.Models.Entities;

namespace Disaster_demo.Services
{
    public interface IGNOfficerServices
    {
        Task<LoginResponseDTO?> GetGnOfficerDetailsAsync(string userId);
    }
}