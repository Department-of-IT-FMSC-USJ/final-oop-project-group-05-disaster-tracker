using Disaster_demo.Models;
using Disaster_demo.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Disaster_demo.Services
{
    public class GNOfficerServices : IGNOfficerServices
    {
        private readonly DisasterDBContext _dbContext;

        public GNOfficerServices(DisasterDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<LoginResponseDTO?> GetGnOfficerDetailsAsync(string userId)
        {
            if (!int.TryParse(userId, out int parsedUserId))
                return null; // Invalid ID format

            var officer = await _dbContext.GN_Officers
                .FirstOrDefaultAsync(g => g.user_id == parsedUserId);

            if (officer == null) return null;

            return new LoginResponseDTO
            {
                UserId = officer.user_id,
                FullName = officer.name,
                ContactNo = officer.contact_no,
                District = officer.district,
                GnDivision = officer.gn_division,
                Role = "GN Officer",
                Message = "GN Officer details fetched successfully"
            };
        }


    }
}
