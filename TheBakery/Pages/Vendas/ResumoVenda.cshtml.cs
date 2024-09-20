using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheBakery.Data;
using TheBakery.Models;

namespace TheBakery.Pages.Vendas
{
    public class ResumoVendaModel : PageModel
    {
        private readonly AppDbContext _context;

        public ResumoVendaModel(AppDbContext context)
        {
            _context = context;
        }

        public int ClienteId { get; set; }
        public string NomeCliente { get; set; }
        public List<Produto> ProdutosVenda { get; set; }
        public decimal ValorTotal { get; set; }

        public void OnGet()
        {
            if (TempData.ContainsKey("ClienteId"))
            {
                ClienteId = (int)TempData["ClienteId"];
                NomeCliente = _context.Clientes.FirstOrDefault(c => c.Id == ClienteId)?.Nome;
            }

            if (TempData.ContainsKey("ProdutosVenda"))
            {
                ProdutosVenda = TempData["ProdutosVenda"] as List<Produto>;
            }

            if (TempData.ContainsKey("ValorTotal"))
            {
                ValorTotal = (decimal)TempData["ValorTotal"];
            }
        }

        public IActionResult OnPost(string formaPagamento)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var venda = new Models.Venda
            {
                ClienteId = ClienteId,
                ValorTotal = ValorTotal,
                FormaPagamento = formaPagamento,
                DataVenda = DateTime.Now,
                Produtos = ProdutosVenda
            };

            _context.Vendas.Add(venda);
            _context.SaveChanges();

            TempData.Clear(); 

            return RedirectToPage("/Index");
        }
    }
}