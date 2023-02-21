using HackerRank.Monitoring.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HackerRank.Monitoring.Infrastructrure.Dbcontexts
{
    public class HRMonitaringDbContext : DbContext
    {
        public HRMonitaringDbContext(DbContextOptions<HRMonitaringDbContext> options)
            : base(options)
        {

        }

        public DbSet<HackerRank_Profile> hackerRank_Profiles { get; set; }
        public DbSet<Topics> topics { get; set; }
        public DbSet<DataStructure_Questions> dataStructure_Questions { get; set; }
        public DbSet<Algorithm_Questions> algorithm_Questions { get; set; }
        public DbSet<Ratings> ratings { get; set; }
    }
}
