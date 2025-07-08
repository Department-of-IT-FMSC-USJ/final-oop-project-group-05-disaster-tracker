using Disaster_demo.Models.Entities;

namespace Disaster_demo.Services
{
    public interface ISymptomsServices
    {
        Task createSymptoms(Symptoms symptoms);
        Task<List<Symptoms>> GetGnApprovedSymptomsByDistrictAsync(string district);

        Task<List<Symptoms>> GetPendingReportsByDivisionAsync(string gnDivision);
        List<Symptoms> GetPendingSymptomsByGnDivision(string gnDivision);
        bool UpdateSymptomStatus(int reportId, string status);
    }
}