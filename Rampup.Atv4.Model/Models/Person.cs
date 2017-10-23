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
        public String Name { get; private set; }
        public String PType { get; private set; }

        public Person(string name, string pType)
        {
            this.ID = new Guid();
            this.Name = name;
            this.PType = pType;
        }

        ~Person(){

        }
    }


}
