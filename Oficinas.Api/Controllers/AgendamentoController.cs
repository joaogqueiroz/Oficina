﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oficinas.Application.Commands.CreateAgendamento;
using Oficinas.Application.Commands.UpdateAgendamento;
using Oficinas.Application.Queries.GetAllAgendamento;
using Oficinas.Application.Queries.GetAgendamentoById;

namespace Oficinas.Api.Controllers
{
    [Route("api/agendamento")]
    [ApiController]
    public class AgendamentoController : ControllerBase
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
        public async Task<IActionResult> Post([FromBody] CreateAgendamentoCommand command)
        {
            var id = 0;
            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateAgendamentoCommand command)
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
