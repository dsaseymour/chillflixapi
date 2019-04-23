using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chillflixapi.Models
{
    public class Match
    {
        public int UserID { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
