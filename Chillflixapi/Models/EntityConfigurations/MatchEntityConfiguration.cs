using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chillflixapi.Models.EntityConfigurations
{
    public class MatchEntityConfiguration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {

        }
    }
}
