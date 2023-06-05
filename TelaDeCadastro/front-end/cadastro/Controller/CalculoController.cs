using Microsoft.AspNetCore.Mvc;

namespace cadastro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculoController : ControllerBase
    {
        [HttpPost]
        public ActionResult<dynamic> Calcular([FromBody] DadosCalculo dados)
        {
            var resultado = (dados.Valor * dados.Parcelas) * 1.05m;

            return new { resultado };
        }
    }

    public class DadosCalculo
    {
        public int Parcelas { get; set; }
        public decimal Valor { get; set; }
    }
}
