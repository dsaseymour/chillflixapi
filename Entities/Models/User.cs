﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace Chillflixapi.Models
{

    public class User : IEntity
    {
        public User()
        {
        }

        public int Id { get; set; }//Primary Key
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime Birthday { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Avatar { get; set; }
        public DateTime CreatedOn { get; set; }

        //Navigation Properties
        public virtual Profile Profile { get; set; }
    }


}
