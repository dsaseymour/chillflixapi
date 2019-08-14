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

        }
    }
}
