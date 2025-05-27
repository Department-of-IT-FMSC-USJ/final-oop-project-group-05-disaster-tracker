using DisasterManagementAPI.Models;
using DisasterManagementAPI.Models.Entities;
using System.Threading.Tasks;

namespace DisasterManagementAPI.Services
{
    public class SymptomService : ISymptomService
    {
        private readonly DisasterMgtSystemDbContext _context;

        public SymptomService(DisasterMgtSystemDbContext context)
        {
            _context = context;
        }

        public async Task<SymptomSubmission> SubmitSymptomsAsync(SymptomSubmission submission)
        {
            _context.SymptomSubmissions.Add(submission);
            await _context.SaveChangesAsync();
            return submission;
        }
    }
}