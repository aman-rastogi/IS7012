using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoreCrud3.Models;

namespace CoreCrud3.Pages.HockeyTeams
{
    public class EditModel : PageModel
    {
        private readonly CoreCrud3.Models.CoreCrud3Context _context;

        public EditModel(CoreCrud3.Models.CoreCrud3Context context)
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
           ViewData["NationalityID"] = new SelectList(_context.Set<Nationality>(), "ID", "ID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(HockeyTeam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HockeyTeamExists(HockeyTeam.ID))
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

        private bool HockeyTeamExists(int id)
        {
            return _context.HockeyTeam.Any(e => e.ID == id);
        }
    }
}
