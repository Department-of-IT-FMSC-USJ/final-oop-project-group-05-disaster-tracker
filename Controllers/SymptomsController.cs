using DisasterManagementAPI.Models.Entities;
using DisasterManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DisasterManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SymptomsController : ControllerBase
    {
        private readonly ISymptomService _symptomService;

        public SymptomsController(ISymptomService symptomService)
        {
            _symptomService = symptomService;
        }

        [HttpPost]
        public async Task<IActionResult> SubmitSymptoms([FromBody] SymptomSubmission submission)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _symptomService.SubmitSymptomsAsync(submission);
            return Ok(new { success = true, data = result });
        }
    }
}