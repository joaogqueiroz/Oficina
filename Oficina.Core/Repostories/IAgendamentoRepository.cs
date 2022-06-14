using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oficinas.Core.Entities;

namespace Oficinas.Core.Repostories
{
    public interface IAgendamentoRepository
    {
        Task<List<Agendamento>> GetAllAsync();
        Task<Agendamento> GetByIdAsync(int id);
        Task<Agendamento> GetByIdClient(int idCliente);
        Task<Agendamento> GetByIdOficina(int idOficina);
        Task AddAsync(Agendamento agendamento);
        Task UpdateAsync(Agendamento agendamento);
        Task DeleteAsync(int id);

    }
}
