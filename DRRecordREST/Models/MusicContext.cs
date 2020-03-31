using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DRRecordREST.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options)
            : base(options)
        {

        }

        public DbSet<Record> Records { get; set; } 

    }
}
