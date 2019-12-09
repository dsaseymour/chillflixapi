using System;
namespace Chillflixapi.Models
{

    public class DbInitializer
    {

        public static void Initialize(ChillflixContext context)
        {
            context.Database.EnsureCreated();
            //if users already exist then the database has been seeded
            SeedUsers(context);
            SeedProfiles(context);

            #region media
            #endregion
            #region post

            #endregion
            #region userrating

            #endregion
            context.SaveChanges();
        }

        public static void SeedUsers(ChillflixContext context)
        {
            if (context.Users.Any() && context.Users.Count() > 3)
            {
                return;
            }
            #region users
            string userData = System.IO.File.ReadAllText("Models/Data/userData.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(userData);
            foreach (var userDataVal in users)
            {
                var user = new User();

                user.Id = userDataVal.Id;
                user.City = userDataVal.City;
                user.Country = userDataVal.Country;
                user.Birthday = userDataVal.Birthday;
                user.FirstName = userDataVal.FirstName;
                user.LastName = userDataVal.LastName;
                user.Email = userDataVal.Email;
                user.Password = userDataVal.Password;
                //Password Hash
                //Password Salt
                user.CreatedOn = userDataVal.CreatedOn;
                context.Users.Add(user);
            }
            context.SaveChanges();
            #endregion
        }

        public static void SeedProfiles(ChillflixContext context)
        {
            #region profile
            string profileData = System.IO.File.ReadAllText("Models/Data/profileData.json");
            List<Profile> profiles = JsonConvert.DeserializeObject<List<Profile>>(profileData);
            foreach (var profileDataVal in profiles)
            {
                var profile = new Profile();
                profile.Id = profileDataVal.Id;
                profile.SexualOrientation = profileDataVal.SexualOrientation;
                profile.Gender = profileDataVal.Gender;
                profile.RelationshipStatus = profileDataVal.RelationshipStatus;
                profile.Height = profileDataVal.Height;
                profile.AboutMe = profileDataVal.AboutMe;
                profile.LastActive = profileDataVal.LastActive;
                profile.CreatedOn = profileDataVal.CreatedOn;
                profile.Ethnicity = profileDataVal.Ethnicity;
                profile.PrimaryLanguage = profileDataVal.PrimaryLanguage;
                profile.Education = profileDataVal.Education;
                profile.Religion = profileDataVal.Religion;
                profile.Smokes = profileDataVal.Smokes;
                profile.Drugs = profileDataVal.Smokes;
                profile.Kids = profileDataVal.Kids;
                profile.Pets = profileDataVal.Pets;
                profile.Sign = profileDataVal.Sign;
                profile.Diet = profileDataVal.Diet;
                profile.LookingForAge = profileDataVal.LookingForAge;
                profile.LookingForGender = profileDataVal.LookingForGender;
                profile.UserFkey = profileDataVal.UserFkey;

                context.Profiles.Add(profile);
            }
            context.SaveChanges();
            #endregion

        }

        public static void SeedMatches(ChillflixContext context)
        {
            #region match

            #endregion
        }
    }

}
