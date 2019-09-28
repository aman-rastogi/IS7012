using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreCrud3.Models;

namespace CoreCrud3.Pages.HockeyTeams
{
    public class DeleteModel : PageModel
    {
        private readonly CoreCrud3.Models.CoreCrud3Context _context;

        public DeleteModel(CoreCrud3.Models.CoreCrud3Context context)
        {
            _context = context;
        }

        [BindProperty]
        public HockeyTeam HockeyTeam { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HockeyTeam = await _context.HockeyTeam
                .Include(h => h.nationality).FirstOrDefaultAsync(m => m.ID == id);

            if (HockeyTeam == null)
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

            HockeyTeam = await _context.HockeyTeam.FindAsync(id);

            if (HockeyTeam != null)
            {
                _context.HockeyTeam.Remove(HockeyTeam);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
