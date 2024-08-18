using atv002.Models;
using Microsoft.AspNetCore.Mvc;

namespace atv002.Controllers
{
    [ApiController]
    [Route("api/frete")]
    public class FreteController : ControllerBase
    {
        [HttpPost]
        public IActionResult CalcularFrete(Frete frete)
        {
            return Ok($"O valor do frete com volume {frete.Produto} é {frete.Volume().ToString("F2")}");
        }
    }
}
