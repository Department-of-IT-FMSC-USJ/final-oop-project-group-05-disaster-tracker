using DisasterManagementAPI.Models.Entities;
using System.Threading.Tasks;

namespace DisasterManagementAPI.Services
{
    public interface ISymptomService
    {
        Task<SymptomSubmission> SubmitSymptomsAsync(SymptomSubmission submission);
    }
}