using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Core.Entities
{
    public class Servico: BaseEntity
    {
        public Servico(int unidadeTrabralho, string descricao)
        {
            UnidadeTrabralho = unidadeTrabralho;
            Descricao = descricao;
        }
        public int Id { get; private set; }
        public int UnidadeTrabralho { get; private set; }
        public string Descricao { get; private set; }
    }
}
