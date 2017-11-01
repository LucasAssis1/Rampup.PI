using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.Atv4.Model.Models
{
    class PhysicalPerson : Person
    {
        public string Cpf { get; set; }
        public PhysicalPerson(string cpf, string name) : base(name)
        {
            this.Cpf = cpf;
        }
    }
}
