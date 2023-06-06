using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace YourProject.Controllers
{
    [ApiController]
    [Route("api/consulta")]
    public class ConsultaController : ControllerBase
    {
        private readonly List<KeyValuePair<int, string>> lista = new List<KeyValuePair<int, string>>
        {
            new KeyValuePair<int, string>(1, "João"),
            new KeyValuePair<int, string>(2, "Maria"),
            new KeyValuePair<int, string>(3, "Ana")
        };

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var nome = lista.Find(item => item.Key == id).Value;
            if (nome != null)
            {
                return Ok(nome);
            }
            else
            {
                return NotFound("Nome não encontrado");
            }
        }
    }
}
