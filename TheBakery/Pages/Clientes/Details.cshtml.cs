using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheBakery.Data;
using TheBakery.Models;

namespace TheBakery.Pages.Clientes
{
    public class DetailsModel : PageModel
    {
        private readonly TheBakery.Data.AppDbContext _context;

        public DetailsModel(TheBakery.Data.AppDbContext context)
        {
            _context = context;
        }

        public Cliente Cliente { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }
            else
            {
                Cliente = cliente;
            }
            return Page();
        }
    }
}
