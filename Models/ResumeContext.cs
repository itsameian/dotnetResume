using Microsoft.EntityFrameworkCore;

namespace  dotnetResume.Models{
    class ResumeContext : DbContext {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Responsibility> Responsibilities { get; set; }
        public DbSet<Skill> Skills { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=dotnetResume;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}