using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheBakery.Models;

namespace TheBakery.Pages.Vendas
{
    public class VendaModel : PageModel
    {
        public List<Produto> ProdutosVenda { get; set; } = new List<Produto>();
        public decimal ValorTotal { get; set; }

        public void OnGet()
        {
            // Inicializa a lista de produtos e o valor total, se necessário
            if (TempData.ContainsKey("ProdutosVenda"))
            {
                ProdutosVenda = TempData["ProdutosVenda"] as List<Produto>;
                TempData.Keep();
            }

            if (TempData.ContainsKey("ValorTotal"))
            {
                ValorTotal = (decimal)TempData["ValorTotal"];
                TempData.Keep();
            }
        }

        public IActionResult OnPost(string produtoNome, decimal produtoPreco, int produtoQuantidade, string produtoDescricao)
        {
            var novoProduto = new Produto
            {
                Nome = produtoNome,
                Preco = produtoPreco,
                Quantidade = produtoQuantidade,
                Descricao = produtoDescricao
            };

            ProdutosVenda.Add(novoProduto);
            ValorTotal += novoProduto.Preco * novoProduto.Quantidade;

            TempData["ProdutosVenda"] = ProdutosVenda;
            TempData["ValorTotal"] = ValorTotal;
            TempData.Keep();

            return RedirectToPage(); 
        }
    }
}