using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oficinas.Application.Commands.CreateServico;
using Oficinas.Application.Commands.UpdateServico;
using Oficinas.Application.Queries.GetAllServico;
using Oficinas.Application.Queries.GetServicoById;


namespace Oficinas.Api.Controllers
{
    [Route("api/servico")]
    [ApiController]
    public class ServicoController : ControllerBase
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
        public async Task<IActionResult> Post([FromBody] CreateServicoCommand command)
        {
            var id = 0;
            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateServicoCommand command)
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
