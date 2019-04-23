using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chillflixapi.Models
{
    public class Profile
    {
        //Properties
        public int UserID { get; set; }
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
        public virtual User User { get; set; }
        public virtual ICollection<Match> Matches { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
