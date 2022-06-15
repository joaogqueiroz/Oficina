using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oficinas.Application.Commands.CreateOficina;
using Oficinas.Application.Commands.UpdateOficina;
using Oficinas.Application.Queries.GetAllOficinas;
using Oficinas.Application.Queries.GetOficinaById;


namespace Oficinas.Api.Controllers
{
    [Route("api/oficina")]
    [ApiController]
    public class OficinaController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            return Ok();
        }
        [HttpGet("Id")]
        public async Task<IActionResult> GetById(int Id)
        {
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateOficinaCommand command)
        {
            var id = 0;
            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateOficinaCommand command)
        {
            
            return NoContent();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            return NoContent();
        }
    }
}
