using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Web.Data;
using Proiect_Web.Models;

namespace Proiect_Web.Pages.Brand
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_Web.Data.AutentificareMagazinContext _context;

        public IndexModel(Proiect_Web.Data.AutentificareMagazinContext context)
        {
            _context = context;
        }

        public IList<Proiect_Web.Models.Brand> Brand { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Brands != null)
            {
                Brand = await _context.Brands.ToListAsync();
            }
        }
    }
}
