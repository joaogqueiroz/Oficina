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
        private readonly OficinaDbContext _dbContext;
        public AgendamentoRepository(OficinaDbContext dbContext)
        {
            _dbContext = dbContext;
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

        public async Task UpdateAsync(Agendamento agendamento)
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Agendamento agendamento)
        {
            _dbContext.Agendamentos.Remove(agendamento);
            await _dbContext.SaveChangesAsync();
        }
    }
}
