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
    public class IndexModel : PageModel
    {
        private readonly TheBakery.Data.AppDbContext _context;

        public IndexModel(TheBakery.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Cliente> Cliente { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Cliente = await _context.Clientes.ToListAsync();
        }
    }
}
