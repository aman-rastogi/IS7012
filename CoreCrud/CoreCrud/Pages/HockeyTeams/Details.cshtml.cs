using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreCrud.Models;

namespace CoreCrud.Pages.HockeyTeams
{
    public class DetailsModel : PageModel
    {
        private readonly CoreCrud.Models.CoreCrudContext _context;

        public DetailsModel(CoreCrud.Models.CoreCrudContext context)
        {
            _context = context;
        }

        public HockeyTeam HockeyTeam { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HockeyTeam = await _context.HockeyTeam.FirstOrDefaultAsync(m => m.ID == id);

            if (HockeyTeam == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
