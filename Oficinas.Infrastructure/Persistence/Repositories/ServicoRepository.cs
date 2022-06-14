using Oficinas.Core.Entities;
using Oficinas.Core.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficinas.Infrastructure.Persistence.Repositories
{
    public class ServicoRepository : IServicoRepository
    {
        private readonly OficinaDbContext _dbContex;
        public ServicoRepository(OficinaDbContext dbContex)
        {
            _dbContex = dbContex;
        }
        public Task<List<Servico>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Servico> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Servico servico)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Servico servico)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
