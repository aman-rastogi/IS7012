using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoreCrud3.Models;

namespace CoreCrud3.Pages.Nationalities
{
    public class CreateModel : PageModel
    {
        private readonly CoreCrud3.Models.CoreCrud3Context _context;

        public CreateModel(CoreCrud3.Models.CoreCrud3Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Nationality Nationality { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Nationality.Add(Nationality);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}