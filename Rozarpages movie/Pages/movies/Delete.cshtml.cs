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
    public class DeleteModel : PageModel
    {
        private readonly Rozarpages_movie.Data.Rozarpages_movieContext _context;

        public DeleteModel(Rozarpages_movie.Data.Rozarpages_movieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public movie movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            movie = await _context.movie.FirstOrDefaultAsync(m => m.ID == id);

            if (movie == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            movie = await _context.movie.FindAsync(id);

            if (movie != null)
            {
                _context.movie.Remove(movie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
