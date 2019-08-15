using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chillflixapi.Models
{
   public enum TVorMovie
    { tv,movie}

    public class Media
    {
        //Properties
        public int MediaID { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string Genre { get; set; }
        public string Summary { get; set; }
        public TVorMovie isTVOrMovie { get; set; }
        public Rating OfficialRating { get; set; }

        //Navigation Properties
        public virtual ICollection<UserRating> UserRatings { get; set; }
    }
}