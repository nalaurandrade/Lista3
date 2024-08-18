using atividade_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace atividade_1.Controllers
{
    [ApiController]
    [Route("api/pessoa")]
    public class PessoaController : ControllerBase
    {
        [HttpPost]
        public IActionResult CalcularImc(Pessoa pessoa)
        {
           return Ok($"O valor do IMC da(o) {pessoa.Nome} é  {pessoa.Imc().ToString("F2")}");
        }
    }
}
