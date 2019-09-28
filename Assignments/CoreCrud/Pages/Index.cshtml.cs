using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreCrud.Pages
{

    
    public class IndexModel : PageModel
    {
    private CoreCrudContext _context;
        public IndexModel(CoreCrudContext context)
        {
            _context = context;
        }

        public int NumberOfCountries { get; set; }
        public int NumberOfTeams { get; set; }

        public void OnGet()
        {
            NumberOfCountries = _context.Nationality.Count();
            NumberOfTeams = _context.HockeyTeam.Count();
        }
    }
}
