using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oficinas.Application.Commands.CreateOficina;
using Oficinas.Application.Commands.DeleteOficina;
using Oficinas.Application.Commands.UpdateOficina;
using Oficinas.Application.Queries.GetAllOficinas;
using Oficinas.Application.Queries.GetOficinaById;


namespace Oficinas.Api.Controllers
{
    [Route("api/oficina")]
    [ApiController]
    public class OficinaController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OficinaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            var query = new GetAllOficinasQuery();
            var getAllOficinas = await _mediator.Send(query);

            return Ok(getAllOficinas);
        }
        [HttpGet("Id")]
        public async Task<IActionResult> GetById(int Id)
        {
            var query = new GetOficinaByIdQuery(Id);
            var oficina = await _mediator.Send(query);
            if (oficina == null)
            {
                return NotFound();
            }
            return Ok(oficina);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateOficinaCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateOficinaCommand command)
        {

            await _mediator.Send(command);
            return NoContent();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            var command = new DeleteOficinaCommand(Id);
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
