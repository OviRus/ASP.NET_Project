using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Web.Data;
using Proiect_Web.Models;

namespace Proiect_Web.Pages.Produse
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_Web.Data.AutentificareMagazinContext _context;

        public IndexModel(Proiect_Web.Data.AutentificareMagazinContext context)
        {
            _context = context;
        }

        public IList<Produs> Produs { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Produse != null)
            {
                Produs = await _context.Produse
                .Include(p => p.Brand)
                .Include(p=>p.CategorieProdus).ThenInclude(z=>z.Categorie).ToListAsync();
            }
        }
    }
}
