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
    public class CountryProfileModel : PageModel
    {
        private CoreCrudContext _context;
        public ICollection<Nationality> TeamsOfANationality;

        public CountryProfileModel(CoreCrudContext context)
        {
            _context = context;
        }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TeamsOfANationality = _context.Nationality
                                    .Include(y => y.HockeyTeams)
                                    .Where(x => x.ID == id)
                                    .ToList();

            if (TeamsOfANationality == null)
                return NotFound();

            return Page();

        }
    }
}