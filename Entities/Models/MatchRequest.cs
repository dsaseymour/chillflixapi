﻿using System;
using System.Collections.Generic;

namespace Entities.Models
{

    public class MatchRequest : EntityBase<int>
    {
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
