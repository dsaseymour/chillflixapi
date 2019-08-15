﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chillflixapi.Models.EntityConfigurations
{
    public class MediaEntityConfiguration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            //a Media Entity has a Media EntityID
            //It has many User Ratings 

            builder.HasKey(med => med.MediaID);
            builder.HasMany(ur => ur.UserRatings);
            
        }
    }
}
