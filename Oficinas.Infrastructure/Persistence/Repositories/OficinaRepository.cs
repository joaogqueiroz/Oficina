using Microsoft.EntityFrameworkCore;
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
        private readonly OficinaDbContext _dbContext;
        public OficinaRepository(OficinaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Oficina>> GetAllAsync()
        {
            return await _dbContext.Oficinas.ToListAsync();
        }

        public async Task<Oficina> GetByIdAsync(int id)
        {
            return await _dbContext.Oficinas.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddAsync(Oficina oficina)
        {
            await _dbContext.Oficinas.AddAsync(oficina);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
