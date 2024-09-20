using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheBakery.Data;

namespace TheBakery.Pages.Vendas
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public
 IList<Models.Venda> Vendas
        { get; set; }

        public async Task OnGetAsync()
        {
            Vendas = await _context.Vendas
                .Include(v => v.Cliente)
                .Include(v => v.Produtos)
                .ToListAsync();
        }
    }
}
