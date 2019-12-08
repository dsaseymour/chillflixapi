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
            builder.HasKey(m => m.MatchId);

            builder.HasOne(m => m.ProfileA)
                    .WithMany(p => p.ProfileAfor);

            builder.HasOne(m => m.ProfileB)
                    .WithMany(p => p.ProfileBfor);
        }
    }
}
