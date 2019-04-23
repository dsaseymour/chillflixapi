using Chillflixapi.Models.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Chillflixapi.Models
{
    public class ChillflixapiContext: DbContext
    {

        //Using DbContext with dependency injection
        public ChillflixapiContext(DbContextOptions<ChillflixapiContext> options):base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<UserRating> UserRatings { get; set; }


        //using separate configuration classes with fluent API configuration code 
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());



        }



    }
}
