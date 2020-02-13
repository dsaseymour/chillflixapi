using System;
namespace Entities.Dtos
{
    public class UserForCreationDto
    {
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime Birthday { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
