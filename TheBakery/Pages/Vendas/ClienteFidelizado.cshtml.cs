using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheBakery.Data;
using TheBakery.Models;

namespace TheBakery.Pages.Venda
{
    public class ClienteFidelizadoModel : PageModel
    {
        private readonly AppDbContext _context;

        public ClienteFidelizadoModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Cliente> Clientes { get; set; }

        public void OnGet()
        {
            Clientes = _context.Clientes.Where(c => c.TemFidelidade).ToList();
        }

        public IActionResult OnPost(int clienteId)
        {
            TempData["ClienteId"] = clienteId;
            
            return RedirectToPage("/Vendas/Venda");
        }
    }
}