using System;
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
