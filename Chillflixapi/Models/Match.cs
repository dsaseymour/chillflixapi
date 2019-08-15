using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chillflixapi.Models
{
    public class Match
    {
        public int MatchID { get; set; }
        public virtual Profile ProfileA { get; set; }
        public virtual Profile ProfileB { get; set; }
    }

}
