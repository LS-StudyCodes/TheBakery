using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TheBakery.Pages.Venda
{
    public class EscolhaTipoClienteModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPostClienteFidelizado()
        {
            TempData["TipoCliente"] = "Fidelizado";
            TempData.Keep();
            return RedirectToPage("/Vendas/ClienteFidelizado");
        }

        public IActionResult OnPostClienteSemFidelidade()
        {
            TempData["TipoCliente"] = "SemFidelidade";
            TempData.Keep();
            return RedirectToPage("/Vendas/ClienteSemFidelidade");
        }
    }
}
