using System;
namespace Entities.Models
{
    public class Jprofiletomatchrequest
    {
        public Jprofiletomatchrequest()
        {
        }
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        public int MatchRequestId { get; set; }
        public MatchRequest MatchRequest { get; set; }
    }


}
