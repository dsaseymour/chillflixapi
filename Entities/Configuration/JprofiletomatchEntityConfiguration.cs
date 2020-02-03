using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{

    public class JprofiletomatchEntityConfiguration : IEntityTypeConfiguration<Jprofiletomatch>
    {
        public JprofiletomatchEntityConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Jprofiletomatch> builder)
        {

            builder.HasKey(pm => new { pm.ProfileId, pm.MatchId });
            builder.HasOne(pm => pm.Profile)
                   .WithMany(p => p.Jprofiletomatches)
                   .HasForeignKey(p => p.ProfileId);

            builder.HasOne(pm => pm.Match)
                   .WithMany(p => p.Jprofiletomatches)
                   .HasForeignKey(pm => pm.MatchId);

            #region DataSeeding
            builder.HasData(new
            {
                ProfileId = 2,
                MatchId = 999,
            }, new
            {
                ProfileId = 1,
                MatchId = 999,
            }
            );


            #endregion

        }
    }


}
