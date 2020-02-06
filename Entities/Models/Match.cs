using System;
using System.Collections.Generic;

namespace Entities.Models
{

    public class Match : EntityBase<int>
    {
        //a match contains a match request and a match response object
        public EMatchStatus matchStatus { get; set; }
        public MatchRequest matchRequest { get; set; }
        public MatchResponse matchResponse { get; set; }
        public virtual ICollection<Jprofiletomatch> Jprofiletomatches { get; set; }
    }

}
