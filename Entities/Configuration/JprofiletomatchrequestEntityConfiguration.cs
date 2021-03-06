﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chillflixapi.Models.EntityConfigurations
{


    public class JprofiletomatchrequestEntityConfiguration : IEntityTypeConfiguration<Jprofiletomatchrequest>
    {
        public JprofiletomatchrequestEntityConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Jprofiletomatchrequest> builder)
        {
            builder.HasKey(pm => new { pm.ProfileId, pm.MatchRequestId });
            builder.HasOne(pm => pm.Profile)
                   .WithMany(p => p.Jprofiletomatchrequests)
                   .HasForeignKey(p => p.ProfileId);

            builder.HasOne(pm => pm.MatchRequest)
                   .WithMany(p => p.Jprofiletomatchrequests)
                   .HasForeignKey(p => p.MatchRequestId);

            #region DataSeeding
            builder.HasData(new
            {
                ProfileId = 1,
                MatchRequestId = 888,
                StatusofRequest = ERequestResponseStatus.Sent
            });


            #endregion
        }
    }

}
