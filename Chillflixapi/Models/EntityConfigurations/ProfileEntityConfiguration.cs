﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chillflixapi.Models.EntityConfigurations
{
    public class ProfileEntityConfiguration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Profile>
    {
        void IEntityTypeConfiguration<Profile>.Configure(EntityTypeBuilder<Profile> builder)
        {

        }
    }
}
