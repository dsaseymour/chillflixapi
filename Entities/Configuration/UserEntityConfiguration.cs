using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chillflixapi.Models.EntityConfigurations
{

    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        //Profile is our dependent entity
        //Profile is identified as the dependent entity by passing it as a type parameter in the has foreign key method
        //the has foreign key method takes a lambda that specifies which property in the dependent type is the foreign key
        //User has a key called Id
        //User has a Profile
        //This profile is linked to a user
        //This profile has a Foreign Key called     
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasOne(u => u.Profile)
                    .WithOne(p => p.User)
                    .HasForeignKey("Profile", "UserFkey");


            #region Data Seeding
            builder.HasData(
            new User()
            {
                Id = 1,
                FirstName = "Lebron",
                LastName = "James",
                City = "Akron",
                Country = "United States",
                Birthday = DateTime.Parse("1984-12-30"),
                Email = "kingjames@gmail.com",
                Password = "password123",
                Avatar = "https://placeholder.com/150",
            },
            new User()
            {
                Id = 2,
                FirstName = "Regina",
                LastName = "King",
                City = "Los Angeles",
                Country = "United States",
                Birthday = DateTime.Parse("1971-01-15"),
                Email = "rking@gmail.com",
                Password = "password123",
                Avatar = "https://placeholder.com/150",
            },
            new User()
            {
                Id = 3,
                FirstName = "Aubrey",
                LastName = "Graham",
                City = "Toronto",
                Country = "Canada",
                Birthday = DateTime.Parse("1984-10-24"),
                Email = "drizzydrake@gmail.com",
                Password = "password123",
                Avatar = "https://placeholder.com/150",
            }
            );
            #endregion
        }

    }


}
