using DisasterManagementAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DisasterManagementAPI.Models
{
    public class DisasterMgtSystemDbContext : DbContext
    {
        public DisasterMgtSystemDbContext(DbContextOptions<DisasterMgtSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<SymptomSubmission> SymptomSubmissions { get; set; }

        // ...existing DbSets...

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SymptomSubmission>().ToTable("symptomsubmission");
            base.OnModelCreating(modelBuilder);
        }
    }
}