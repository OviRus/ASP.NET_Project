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
    public class DeleteModel : PageModel
    {
        private readonly Proiect_Web.Data.AutentificareMagazinContext _context;

        public DeleteModel(Proiect_Web.Data.AutentificareMagazinContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Produs Produs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Produse == null)
            {
                return NotFound();
            }

            var produs = await _context.Produse.FirstOrDefaultAsync(m => m.Id == id);

            if (produs == null)
            {
                return NotFound();
            }
            else 
            {
                Produs = produs;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Produse == null)
            {
                return NotFound();
            }
            var produs = await _context.Produse.FindAsync(id);

            if (produs != null)
            {
                Produs = produs;
                _context.Produse.Remove(Produs);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
