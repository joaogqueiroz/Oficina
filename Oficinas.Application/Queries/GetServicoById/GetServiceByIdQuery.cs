﻿using MediatR;
using Oficinas.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficinas.Application.Queries.GetServicoById
{
    public class GetServiceByIdQuery : IRequest<ServicoViewModel>
    {
        public GetServiceByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
