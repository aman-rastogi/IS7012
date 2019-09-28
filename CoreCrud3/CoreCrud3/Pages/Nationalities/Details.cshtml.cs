using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreCrud3.Models;

namespace CoreCrud3.Pages.Nationalities
{
    public class DetailsModel : PageModel
    {
        private readonly CoreCrud3.Models.CoreCrud3Context _context;

        public DetailsModel(CoreCrud3.Models.CoreCrud3Context context)
        {
            _context = context;
        }

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
    }
}
