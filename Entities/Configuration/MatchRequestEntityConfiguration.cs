using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{

    public class MatchRequestEntityConfiguration : IEntityTypeConfiguration<MatchRequest>
    {
        public MatchRequestEntityConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<MatchRequest> builder)
        {
            builder.HasKey(u => u.Id);

            #region DataSeeding
            builder.HasData(new
            {
                Id = 888,
                MatchFkey = 999,
                StatusofRequest = ERequestResponseStatus.Sent,
                ResponderFkey = 2
            }

            );


            #endregion

        }
    }

}
