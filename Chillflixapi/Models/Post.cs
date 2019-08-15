using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chillflixapi.Models
{
    public class Post
    {
        //Properties
        public int PostID { get; set; }
        public string Text { get; set; }
        public string PostPrompt { get; set; }
        //Navigation Properties
        public int ProfileID { get; set; }//ForeignKey to represent association with profile
        public virtual Profile Profile { get; set; }
    }
}
