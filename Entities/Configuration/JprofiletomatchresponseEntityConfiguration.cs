using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Models;


namespace Entities.Configuration
{

    public class JprofiletomatchresponseEntityConfiguration : IEntityTypeConfiguration<Jprofiletomatchresponse>
    {
        public JprofiletomatchresponseEntityConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Jprofiletomatchresponse> builder)
        {
            builder.HasKey(pm => new { pm.ProfileId, pm.MatchResponseId });
            builder.HasOne(pm => pm.Profile)
                   .WithMany(p => p.Jprofiletomatchresponses)
                   .HasForeignKey(p => p.ProfileId);

            builder.HasOne(pm => pm.MatchResponse)
                   .WithMany(pz => pz.Jprofiletomatchresponses)
                   .HasForeignKey(pm => pm.MatchResponseId);

            #region DataSeeding
            builder.HasData(new
            {
                ProfileId = 2,
                MatchResponseId = 777,
                StatusofRequst = ERequestResponseStatus.Rejected
            });


            #endregion


        }
    }


}
