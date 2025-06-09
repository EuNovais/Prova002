using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova002
{
    public class Cliente
    {
        public int Id { get;}
        public string Nome { get;}
        public string Email { get;}
        public string Cpf { get;}

        public Cliente(int id, string nome, string email, string cpf)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
        }
    }
}
