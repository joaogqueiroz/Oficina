using Oficinas.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficinas.Core.Entities
{
    public class Usuario : BaseEntity
    {
        public Usuario(string nomeCompleto, string email, DateOnly dataNascimento, DateOnly dataCriacao, string senha, RolesEnum role)
        {
            NomeCompleto = nomeCompleto;
            Email = email;
            DataNascimento = dataNascimento;
            DataCriacao = dataCriacao;
            Senha = senha;
            Role = role;
        }

        public string NomeCompleto { get; private set; }
        public string Email { get; private set; }
        public DateOnly DataNascimento { get; private set; }
        public DateOnly DataCriacao { get; private set; }
        public string Senha { get; private set; }
        public RolesEnum Role { get; private set; }
    }
}
