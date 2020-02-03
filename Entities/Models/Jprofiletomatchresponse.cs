using System;
namespace Entities.Models
{

    public class Jprofiletomatchresponse
    {
        public Jprofiletomatchresponse()
        {
        }

        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        public int MatchResponseId { get; set; }
        public MatchResponse MatchResponse { get; set; }

    }

}
