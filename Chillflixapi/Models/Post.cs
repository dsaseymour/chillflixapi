using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chillflixapi.Models
{
    public class Post
    {
        public int UserID { get; set; }//ForeignKey to represent association with profile
        //Properties
        public string Text { get; set; }
        public string PostPrompt { get; set; }
        //Navigation Properties
        public virtual Profile Profile { get; set; }
    }
}
