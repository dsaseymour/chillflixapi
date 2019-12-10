using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chillflixapi.Models.EntityConfigurations
{

    public class MatchResponseEntityConfiguration : IEntityTypeConfiguration<MatchResponse>
    {
        public MatchResponseEntityConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<MatchResponse> builder)
        {
            builder.HasKey(u => u.Id);

            #region DataSeeding
            builder.HasData(new
            {
                Id = 777,
                MatchFkey = 999,
                StatusofResponse = ERequestResponseStatus.Rejected,
                RequesterFkey = 1
            });


            #endregion
        }
    }

}
