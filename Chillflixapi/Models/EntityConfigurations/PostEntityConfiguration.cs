using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chillflixapi.Models.EntityConfigurations
{
    public class PostEntityConfiguration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Post>
    {
        void IEntityTypeConfiguration<Post>.Configure(EntityTypeBuilder<Post> builder)
        {

        }
    }
}
