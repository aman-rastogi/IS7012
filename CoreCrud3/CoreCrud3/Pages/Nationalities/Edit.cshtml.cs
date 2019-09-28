using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoreCrud3.Models;

namespace CoreCrud3.Pages.Nationalities
{
    public class EditModel : PageModel
    {
        private readonly CoreCrud3.Models.CoreCrud3Context _context;

        public EditModel(CoreCrud3.Models.CoreCrud3Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Nationality Nationality { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Nationality = await _context.Nationality.FirstOrDefaultAsync(m => m.ID == id);

            if (Nationality == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Nationality).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NationalityExists(Nationality.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool NationalityExists(int id)
        {
            return _context.Nationality.Any(e => e.ID == id);
        }
    }
}
