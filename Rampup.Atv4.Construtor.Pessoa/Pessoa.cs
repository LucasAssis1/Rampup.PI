using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.Atv4.Construtor.Model
{
    public class Pessoa
    {
        public int ID { get; private set; }
        public String Nome { get; private set; }
        public DateTime Nascimento { get; private set; }

        public Pessoa(int id, String nome, DateTime nascimento)
        {
            this.ID = id;
            this.Nome = nome;
            this.Nascimento = nascimento;
        }
    }
}
