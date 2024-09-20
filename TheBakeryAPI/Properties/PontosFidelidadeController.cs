module PontosFidelidadeController
using Microsoft.AspNetCore.Mvc;

namespace TheBakery.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PontosFidelidadeController : ControllerBase
    {
        [HttpPost("calcular")]
        public IActionResult CalcularPontos([FromBody] decimal valorTotalVenda)
        {
            int pontos = CalcularPontosFidelidade(valorTotalVenda);

            return Ok(new { Pontos = pontos });
        }

        private int CalcularPontosFidelidade(decimal valorTotalVenda)
        {

            int pontos = (int)(valorTotalVenda / 10);
            return pontos;
        }
    }
}