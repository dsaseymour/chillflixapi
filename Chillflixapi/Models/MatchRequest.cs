using System;
using System.Collections.Generic;

namespace Chillflixapi.Models
{

    public class MatchRequest
    {
        public int Id { get; set; }
        public ERequestResponseStatus StatusofRequest { get; set; }
        #region joinTables
        public int MatchFkey { get; set; }
        public Match Match { get; set; }
        public int ResponderFkey { get; set; }
        public Profile Responder { get; set; }
        public virtual ICollection<Jprofiletomatchrequest> Jprofiletomatchrequests { get; set; }
        #endregion
    }

}
