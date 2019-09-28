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
    public class IndexModel : PageModel
    {
        private readonly CoreCrud3.Models.CoreCrud3Context _context;

        public IndexModel(CoreCrud3.Models.CoreCrud3Context context)
        {
            _context = context;
        }

        public IList<HockeyTeam> HockeyTeam { get;set; }

        public async Task OnGetAsync()
        {
            HockeyTeam = await _context.HockeyTeam
                .Include(h => h.nationality).ToListAsync();
        }
    }
}
