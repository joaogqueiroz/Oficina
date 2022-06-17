using FluentValidation;
using Oficinas.Application.Commands.UpdateAgendamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficinas.Application.Validators
{
    public class UpdateAgendamentoCommandValidator : AbstractValidator<UpdateAgendamentoCommand>
    {
        public UpdateAgendamentoCommandValidator()
        {

        RuleFor(a => a.IdServico)
                .NotEmpty()
                .NotNull()
                .WithMessage("Id do servico e obrigatorio!");


        RuleFor(a => a.DataAgendamento)
                .NotEmpty()
                .NotNull()
                .WithMessage("data do agendamento e obrigatoria!");

        }
    }
}
