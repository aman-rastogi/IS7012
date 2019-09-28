using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CoreCrud.Pages
{
    public class RosterModel : PageModel
    {
        private CoreCrudContext _context;
        public ICollection<HockeyTeam> HockeyTeams;
        public RosterModel(CoreCrudContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            HockeyTeams = _context.HockeyTeam
                                        .Include(x => x.nationality)
                                        .OrderByDescending(x => x.Wins)
                                        .ToList();
        }
    }
}