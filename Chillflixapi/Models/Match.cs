using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chillflixapi.Models
{
    public class Match
    {
        public int MatchProfileAFkey {get;set;}
        public int MatchProfileBFkey {get;set;}

        public virtual Profile MatchProfileA { get; set; }
        public virtual Profile MatchProfileB { get; set; }
    }

}
