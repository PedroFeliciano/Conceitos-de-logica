using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public bool EGay { get; set; }
 
        public Pessoa(bool EGay,string nome)
        {
            this.EGay = EGay;
            Nome = nome;
        }
    }
}
