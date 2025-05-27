using System;

namespace DisasterManagementAPI.Models.Entities
{
    public class SymptomSubmission
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ContactNo { get; set; }
        public string District { get; set; }
        public string GNDivision { get; set; }
        public DateTime DateTime { get; set; }
        public string Symptoms { get; set; }
        public string? ImageUrl { get; set; }
    }
}