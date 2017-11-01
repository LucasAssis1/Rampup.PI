using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.Atv4.Model.Models
{
    public class LegalPerson : Person
    {
        public string Cnpj { get; private set; }
        public LegalPerson(string cnpj, string name) : base(name)
        {
            this.Cnpj = cnpj;
        }

    }
}
