using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Rampup.Atv4.Model.Commom;

namespace Rampup.Atv4.Model
{
    public class Account
    {
        public Guid ID { get; private set; }
        public TipoConta Type_Ac { get; private set; }
        public Person Owner { get; private set; }

        public Double Balance { get; private set; }

        public DateTime CreationDate { get; private set ; }

        public Account(TipoConta type_Ac, Person owner)
        {
            this.ID = new Guid();
            this.Type_Ac = type_Ac;
            this.Owner = owner;
            this.CreationDate = DateTime.Now;
        }
        public void CalcSaldo(double balance)
        {
            this.Balance += balance;
        }


    }
}
