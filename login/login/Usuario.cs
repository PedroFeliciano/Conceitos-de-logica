using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    public class Usuario
    {
        public string Email {get;set;}
        public string Senha { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool IsAdmin { get; set; }
        public Usuario()
        {

        }
        public Usuario(string email, string senha, string nome, DateTime dataNasc,bool isAdmin)
        {
            Email = email;
            Senha = senha;
            Nome = nome;
            DataNascimento = dataNasc;
        }
    }
}
