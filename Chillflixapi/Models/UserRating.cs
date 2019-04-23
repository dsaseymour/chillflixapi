using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chillflixapi.Models
{
//    public int[] Rating = new [] {1,2,3,4,5,6,7,8,9,10};

    public class UserRating
    {
        //Properties
        public int UserRatingID { get; set; }
        public int MediaID { get; set; }
        public int UserID { get; set; }
  //      public Rating Rating { get; set; }

        //Navigation Properties
        public virtual Media Media { get; set; }
        public virtual User User { get; set; }
    }
}
