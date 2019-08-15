using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chillflixapi.Models.EntityConfigurations
{
    public class UserRatingEntityConfiguration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<UserRating>
    {
        public void Configure(EntityTypeBuilder<UserRating> builder)
        {
            builder.HasKey(ur => new { ur.MediaID,ur.ProfileID});
            builder.HasOne(t => t.Media);
            builder.HasOne(o => o.Profile);
        }
        //user rating is identified by a mediaid and userid
        //a user can only generate one rating for each piece of media
    }
}
