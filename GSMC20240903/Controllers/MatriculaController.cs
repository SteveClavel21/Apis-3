using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GSMC20240903.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GSMC20240903.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MatriculaController : ControllerBase
    {
        static List<Matricula> matriculas = new List<Matricula>();
        // GET: api/<MatriculaController>
        [HttpGet]
        public IEnumerable<Matricula> Get()
        {
            return matriculas;
        }

        // GET api/<MatriculaController>/5
        [HttpGet("{id}")]
        public Matricula Get(int id)
        {
            var matricula = matriculas.FirstOrDefault(c => c.id == id);
            return matricula;
        }

        // POST api/<MatriculaController>
        [HttpPost]
        public IActionResult Post([FromBody] Matricula matricula)
        {
            matriculas.Add(matricula);
            return Ok();
        }

        // PUT api/<MatriculaController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Matricula matricula)
        {
            var existingmatricula = matriculas.FirstOrDefault(y => y.id == id);
            if (existingmatricula != null)
            {
                existingmatricula.nombre = matricula.nombre;
                return Ok();
            }
            else return NotFound();
        }

       
       
    }
}
