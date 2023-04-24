using Exercicio_Semana9.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exercicio_Semana9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SemanaController : ControllerBase
    {
        private readonly SemanaContext semanaContext;

        public SemanaController(SemanaContext semanaContext)
        {
            this.semanaContext = semanaContext;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPost("POST")]

        public ActionResult Post([FromBody] SemanaModel semanaModel)
        {
            if (semanaModel.id > 0)
            {
                return Ok(true);
            }
            {
                return BadRequest("ID precisa ser maior que O");
            }
        }
        [HttpPut("PUT")]

        public ActionResult Put([FromBody] SemanaModel semanaModel)
        {
            if (semanaModel.id > 0)
            {
                return Ok(true);
            }
            {
                return BadRequest("ID precisa ser maior que O");
            }
        }
        [HttpDelete("DELETE")]

        public ActionResult Delete([FromRoute]int id)
        {
            var Id = semanaContext.Semana.Find(id);

            if (Id == null)
            {
                return NotFound();
            }

            semanaContext.Semana.Remove(Id);
            semanaContext.SaveChanges();

            return NoContent();
        }

    }
}



