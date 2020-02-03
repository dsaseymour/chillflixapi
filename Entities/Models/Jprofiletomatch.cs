using System;
namespace Entities.Models
{

    public class Jprofiletomatch
    {
        public Jprofiletomatch()
        {
        }

        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        public int MatchId { get; set; }
        public Match Match { get; set; }


    }


}
