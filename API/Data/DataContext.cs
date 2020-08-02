using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Responsibility> Responsibilities { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}