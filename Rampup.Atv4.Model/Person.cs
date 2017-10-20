using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Rampup.Atv4.Model.Commom;

namespace Rampup.Atv4.Model
{
    public class Person
    {
        public Guid ID { get; private set; }
        public String Nome { get; private set; }
        public TipoPessoa Tipo { get; private set; }

        public Person(string nome, TipoPessoa tipo)
        {
            this.ID = new Guid();
            this.Nome = nome;
            this.Tipo = tipo;
        }

        ~Person(){

        }
    }


}
