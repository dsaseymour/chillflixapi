using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chillflixapi.Models
{
    public class Message
    {
        //Properties
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime MessageSent {get;set;}
        public bool Read {get;set;}
        


    }
}