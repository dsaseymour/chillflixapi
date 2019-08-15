using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chillflixapi.Models
{
    public enum Rating {One,Two,Three,Four,Five,Six,Seven,Eight,Nine,Ten};

    public class UserRating
    {
        //Properties
        public int MediaID { get; set; }
        public int ProfileID { get; set; }
  //      public Rating Rating { get; set; }

        //Navigation Properties
        public virtual Media Media { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
