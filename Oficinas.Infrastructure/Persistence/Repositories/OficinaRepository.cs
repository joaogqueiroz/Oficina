using Oficinas.Core.Entities;
using Oficinas.Core.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficinas.Infrastructure.Persistence.Repositories
{
    public class OficinaRepository : IOficinaRepository
    {
        private readonly OficinaDbContext _dbContex;
        public OficinaRepository(OficinaDbContext dbContex)
        {
            _dbContex = dbContex;
        }

        public Task<List<Oficina>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Oficina> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Oficina oficina)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Oficina oficina)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
