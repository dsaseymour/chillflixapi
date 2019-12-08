using Chillflixapi.Models.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Chillflixapi.Models
{

    public class ChillflixContext : DbContext
    {
        public string ConnectionString { get; set; }


        public ChillflixContext(DbContextOptions<ChillflixContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProfileEntityConfiguration());
            /*
            modelBuilder.ApplyConfiguration(new MatchEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PostEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProfileEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UserRatingEntityConfiguration());
            modelBuilder.ApplyConfiguration(new MediaEntityConfiguration());
            */
        }
    }


}
