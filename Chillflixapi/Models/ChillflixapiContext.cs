using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Chillflixapi.Models
{
    public class ChillflixapiContext: DbContext
    {

        //Using DbContext with dependency injection
        public ChillflixapiContext(DbContextOptions<ChillflixapiContext> options):base(options)
        {
        }


    }
}
