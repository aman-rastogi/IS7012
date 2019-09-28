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
    public class IndexModel : PageModel
    {
        private readonly CoreCrud3.Models.CoreCrud3Context _context;

        public IndexModel(CoreCrud3.Models.CoreCrud3Context context)
        {
            _context = context;
        }

        public IList<Nationality> Nationality { get;set; }

        public async Task OnGetAsync()
        {
            Nationality = await _context.Nationality.ToListAsync();
        }
    }
}
