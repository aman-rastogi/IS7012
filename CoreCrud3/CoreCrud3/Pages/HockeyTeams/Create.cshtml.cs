using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoreCrud3.Models;

namespace CoreCrud3.Pages.HockeyTeams
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
        ViewData["NationalityID"] = new SelectList(_context.Set<Nationality>(), "ID", "ID");
            return Page();
        }

        [BindProperty]
        public HockeyTeam HockeyTeam { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.HockeyTeam.Add(HockeyTeam);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}