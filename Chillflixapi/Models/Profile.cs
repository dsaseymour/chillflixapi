using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chillflixapi.Models
{
    public class Profile
    {
        //Properties
        public int ProfileId {get;set;}
        #region basics
        public string SexualOrientation { get; set; }
        public string Gender { get; set; }
        public string RelationshipStatus { get; set; }
        public int Height { get; set; }
        public string AboutMe { get; set; }
        #endregion

        #region background
        public string Ethnicity { get; set; }
        public string PrimaryLanguage { get; set; }
        public string Education { get; set; }
        public string Religion { get; set; }
        #endregion

        #region details
        public string Smokes { get; set; }
        public string Drinks { get; set; }
        public string Drugs { get; set; }
        public string Kids { get; set; }
        public string Pets { get; set; }
        public string Sign { get; set; }
        public string Diet { get; set; }
        #endregion

        #region lookingfor
    	public string LookingForGender { get; set; }
        public string LookingForAge { get; set; }
        #endregion

        //Navigation Properties
        public int UserFkey{get;set;}
        public virtual User User { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<UserRating> UserRatings { get; set; }

        //this profile has a list of matches it will be profileA or profileB for
        public List<Match> ProfileAfor { get; set; }
        public List<Match> ProfileBfor { get; set; }
    }
}
//https://entityframeworkcore.com/knowledge-base/50398457/2-foreign-keys-as-primary-key-using-ef-core-2-0-code-first