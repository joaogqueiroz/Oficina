using FluentValidation;
using Oficinas.Application.Commands.CreateAgendamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficinas.Application.Validators
{
    public class CreateAgendamentoCommandValidator : AbstractValidator<CreateAgendamentoCommand>
    {
        public CreateAgendamentoCommandValidator()
        {
            RuleFor(a => a.IdServico)
                .NotEmpty()
                .NotNull()
                .WithMessage("Id do servico e obrigatorio!");

            RuleFor(a => a.IdOficina)
                .NotEmpty()
                .NotNull()
                .WithMessage("Id da oficina e obrigatorio!");

            RuleFor(a => a.DataAgendamento)
                .NotEmpty()
                .NotNull()
                .WithMessage("data do agendamento e obrigatoria!");
        }
    }
}
