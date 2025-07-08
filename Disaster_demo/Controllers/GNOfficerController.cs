using Disaster_demo.Services;
using Microsoft.AspNetCore.Mvc;

namespace Disaster_demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GNOfficerController : ControllerBase
    {
        private readonly IGNOfficerServices _gnofficerServices;

        public GNOfficerController(IGNOfficerServices GnofficerServices)
        {
            this._gnofficerServices = GnofficerServices;
        }

        [HttpGet("details/{userId}")]
        public async Task<IActionResult> GetGnOfficerDetails(string userId)
        {
            var officerDetails = await _gnofficerServices.GetGnOfficerDetailsAsync(userId);

            if (officerDetails == null)
                return NotFound();

            return Ok(officerDetails);
        }
    }
}