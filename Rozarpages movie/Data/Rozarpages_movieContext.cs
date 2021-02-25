using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rozarpages_movie.Model;

namespace Rozarpages_movie.Data
{
    public class Rozarpages_movieContext : DbContext
    {
        public Rozarpages_movieContext (DbContextOptions<Rozarpages_movieContext> options)
            : base(options)
        {
        }

        public DbSet<Rozarpages_movie.Model.movie> movie { get; set; }
    }
}
