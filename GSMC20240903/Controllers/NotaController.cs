using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GSMC20240903.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class NotaController : ControllerBase
    {
        static List<float> notas = new List<float>();
        // GET: api/<NotaController>
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<float> Get()
        {
            return notas;
        }

        

        // POST api/<NotaController>
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] float nota)
        {
            notas.Add(nota);
            return Ok();
        }

       
    }
}
