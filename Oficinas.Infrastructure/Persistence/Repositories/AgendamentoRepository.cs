using Oficinas.Core.Entities;
using Oficinas.Core.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficinas.Infrastructure.Persistence.Repositories
{
    public class AgendamentoRepository : IAgendamentoRepository
    {
        private readonly OficinaDbContext _dbContex;
        public AgendamentoRepository(OficinaDbContext dbContex)
        {
            _dbContex = dbContex;
        }

        public Task<List<Agendamento>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Agendamento> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Agendamento> GetByIdClient(int idCliente)
        {
            throw new NotImplementedException();
        }

        public Task<Agendamento> GetByIdOficina(int idOficina)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Agendamento agendamento)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Agendamento agendamento)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
