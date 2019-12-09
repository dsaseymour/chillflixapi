using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chillflixapi.Models.EntityConfigurations
{
    public class ProfileEntityConfiguration : IEntityTypeConfiguration<Profile>
    {
        public ProfileEntityConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasMany(p => p.iamrequesterin)
                .WithOne(e => e.Requester)
                .HasForeignKey(f => f.RequesterFkey);

            builder.HasMany(p => p.iamresponderin)
                .WithOne(a => a.Responder)
                .HasForeignKey(j => j.ResponderFkey);


            #region Data Seeding
            builder.HasData(
            new Profile()
            {
                Id = 1,
                SexualOrientation = "Straight",
                Gender = "Male",
                RelationshipStatus = "Single",
                Height = "6'8",
                AboutMe = "EST. AKRON - ST.V/M Class of '03 http://LeBronJamesFamilyFoundation.org  #IPROMISE",
                LastActive = DateTime.Parse("2019-05-20"),
                CreatedOn = DateTime.Parse("2019-05-10"),
                Ethnicity = "Black",
                PrimaryLanguage = "English",
                Education = "High School",
                Religion = "Christian",
                Smokes = "No",
                Drinks = "Yes",
                Drugs = "No",
                Kids = "Yes",
                Pets = "Yes",
                Sign = "Aries",
                Diet = "Paleo",
                LookingForGender = "Female",
                LookingForAge = 28,
                UserFkey = 1
            },
            new Profile()
            {
                Id = 2,
                SexualOrientation = "Straight",
                Gender = "Female",
                RelationshipStatus = "Single",
                Height = "5'3",
                AboutMe = "Classically Beautiful",
                LastActive = DateTime.Parse("2018-03-03"),
                CreatedOn = DateTime.Parse("2017-03-04"),
                Ethnicity = "Black",
                PrimaryLanguage = "English",
                Education = "Bachelors of Arts",
                Religion = "Christian",
                Smokes = "No",
                Drinks = "No",
                Drugs = "No",
                Kids = "Yes",
                Pets = "Yes",
                Sign = "Capricorn",
                Diet = "Vegan",
                LookingForGender = "Male",
                LookingForAge = 50,
                UserFkey = 2
            },
            new Profile()
            {
                Id = 3,
                SexualOrientation = "Straight",
                Gender = "Male",
                RelationshipStatus = "Single",
                Height = "6'0",
                AboutMe = "Octobers Very Own",
                LastActive = DateTime.Parse("2019-03-04"),
                CreatedOn = DateTime.Parse("2019-01-20"),
                Ethnicity = "Black",
                PrimaryLanguage = "English",
                Education = "High School",
                Religion = "Jewish",
                Smokes = "No",
                Drinks = "Yes",
                Drugs = "No",
                Kids = "Yes",
                Pets = "Yes",
                Sign = "Scorpio",
                Diet = "Vegan",
                LookingForGender = "Female",
                LookingForAge = 27,
                UserFkey = 3
            }
            );
            #endregion

        }
    }



}
