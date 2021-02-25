using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rozarpages_movie.Data;
using Rozarpages_movie.Model;

namespace Rozarpages_movie.Pages.movies
{
    public class IndexModel : PageModel
    {
        private readonly Rozarpages_movie.Data.Rozarpages_movieContext _context;

        public IndexModel(Rozarpages_movie.Data.Rozarpages_movieContext context)
        {
            _context = context;
        }

        public IList<movie> movie { get;set; }

        public async Task OnGetAsync()
        {
            movie = await _context.movie.ToListAsync();
        }
    }
}
