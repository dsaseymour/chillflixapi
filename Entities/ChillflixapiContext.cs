using Chillflixapi.Models.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Chillflixapi.Models
{

    public class ChillflixapiContext : DbContext
    {
        public string ConnectionString { get; set; }


        public ChillflixapiContext(DbContextOptions<ChillflixapiContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<MatchResponse> MatchResponses { get; set; }
        public DbSet<MatchRequest> MatchRequests { get; set; }
        public DbSet<Match> Matches { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProfileEntityConfiguration());

            modelBuilder.ApplyConfiguration(new JprofiletomatchEntityConfiguration());
            modelBuilder.ApplyConfiguration(new JprofiletomatchrequestEntityConfiguration());
            modelBuilder.ApplyConfiguration(new JprofiletomatchresponseEntityConfiguration());
            modelBuilder.ApplyConfiguration(new MatchEntityConfiguration());
            modelBuilder.ApplyConfiguration(new MatchRequestEntityConfiguration());
            modelBuilder.ApplyConfiguration(new MatchResponseEntityConfiguration());
            /*
            modelBuilder.ApplyConfiguration(new PostEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UserRatingEntityConfiguration());
            modelBuilder.ApplyConfiguration(new MediaEntityConfiguration());
            */





        }
    }

}
