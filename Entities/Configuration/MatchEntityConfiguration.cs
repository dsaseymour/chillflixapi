using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Models;


namespace Entities.Configuration
{

    public class MatchEntityConfiguration : IEntityTypeConfiguration<Match>
    {
        public MatchEntityConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasOne<MatchRequest>("matchRequest")
                    .WithOne("Match")
                    .HasForeignKey("MatchRequest", "MatchFkey")
                    ;
            builder.HasOne<MatchResponse>("matchResponse")
                    .WithOne("Match")
                    .HasForeignKey("MatchResponse", "MatchFkey");

            #region DataSeeding
            builder.HasData(new
            {
                Id = 999,
                matchStatus = EMatchStatus.Rejected

            });


            #endregion

        }
    }

}
