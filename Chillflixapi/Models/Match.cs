using System;
using System.Collections.Generic;

namespace Chillflixapi.Models
{

    public class Match
    {
        public int Id { get; set; }
        //a match contains a match request and a match response object
        public EMatchStatus matchStatus { get; set; }
        public MatchRequest matchRequest { get; set; }
        public MatchResponse matchResponse { get; set; }
        public virtual ICollection<Jprofiletomatch> Jprofiletomatches { get; set; }
    }

}
