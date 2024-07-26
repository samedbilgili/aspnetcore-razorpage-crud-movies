using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TutorialAspnetCoreRazorPages.Data;
using TutorialAspnetCoreRazorPages.Models;

namespace TutorialAspnetCoreRazorPages.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly TutorialAspnetCoreRazorPages.Data.TutorialAspnetCoreRazorPagesContext _context;

        public CreateModel(TutorialAspnetCoreRazorPages.Data.TutorialAspnetCoreRazorPagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Movie == null || Movie == null)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
