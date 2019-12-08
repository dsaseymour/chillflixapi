using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chillflixapi.Models.EntityConfigurations
{
    public class ProfileEntityConfiguration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            //User Id should Identify the profile
            builder.HasKey(p => p.ProfileId );

            builder.HasMany(pts => pts.Posts)
                .WithOne(p => p.Profile);

            //a match should link two profiles 

            builder.HasMany(urt => urt.UserRatings)
                .WithOne(p => p.Profile);
            //user rating should link to a profile and a media object

        }
    }
}
