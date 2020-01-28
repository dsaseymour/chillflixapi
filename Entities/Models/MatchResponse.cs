using System;
using System.Collections.Generic;

namespace Chillflixapi.Models
{

    public class MatchResponse
    {
        public int Id { get; set; }
        public ERequestResponseStatus StatusofResponse { get; set; }
        #region joinTables
        public int MatchFkey { get; set; }
        public Match Match { get; set; }
        public int RequesterFkey { get; set; }
        public Profile Requester { get; set; }
        public virtual ICollection<Jprofiletomatchresponse> Jprofiletomatchresponses { get; set; }
        #endregion


    }

}
