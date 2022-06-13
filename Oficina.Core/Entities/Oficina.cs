using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Core.Entities
{
    public class Oficina : BaseEntity
    {
        public Oficina(string nome, int qtdMaxUnidadeTrabralho, string cnpj)
        {
            Nome = nome;
            QtdMaxUnidadeTrabralho = qtdMaxUnidadeTrabralho;
            Cnpj = cnpj;
        }
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int QtdMaxUnidadeTrabralho { get; private set; }
        public string Cnpj { get; private set; }
    }
}
