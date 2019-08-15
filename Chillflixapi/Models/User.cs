using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chillflixapi.Models
{
    public class User
    {
        //Properties
        public int UserID { get; set; }//Primary Key
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime Birthday { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public DateTime CreatedOn { get; set; }

        //Navigation Properties
        public int ProfileID { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
