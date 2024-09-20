using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheBakery.Data;
using TheBakery.Models;

namespace TheBakery.Pages.Venda
{
    public class ClienteSemFidelidadeModel : PageModel
    {
        private readonly AppDbContext _context;

        public ClienteSemFidelidadeModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cliente Cliente { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Cliente.TemFidelidade = false;
            Cliente.PontosFidelidade = 0;
            _context.Clientes.Add(Cliente);
            _context.SaveChanges();

            TempData["ClienteId"] = Cliente.Id;
            TempData.Keep();

            return RedirectToPage("/Vendas/Venda");
        }
    }
}