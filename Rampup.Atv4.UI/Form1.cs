using Rampup.Atv4.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Rampup.Atv4.Model.Commom;

namespace Rampup.Atv4.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IList<Account> RegisteredAccounts;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            double saldo = Convert.ToDouble(txtBalance.Text);
            //var ptipo = Enum.GetValues(Enum.Get);
            var pType = TipoPessoa.Fisica;
            var aType = TipoConta.Corrente;

            if (comboPersonType.Text == "Fisica")
                pType = TipoPessoa.Fisica;
            else
                pType = TipoPessoa.Juridica;
            if (comboBoxAccountType.Text == "Poupanca")
                aType = TipoConta.Poupança;
            else
                aType = TipoConta.Corrente;
            
            Person p1 = new Person(name, pType);
            Account c1 = new Account(aType, p1);

            c1.CalcSaldo(saldo);

            txtUserName.Clear();
            txtAccount.Clear();
            txtAgency.Clear();
            txtAccount.Clear();
            comboPersonType.ResetText();
            comboBoxAccountType.ResetText();
            


            MessageBox.Show("Dono :" + c1.Owner.Nome + "\nTipo Pessoa: " + p1.Tipo + "\nTipo Conta: " + c1.Type_Ac + "\nCliente desde: " + c1.CreationDate.ToShortDateString() + "\nSaldo: " + c1.Balance);
        }
    }
}
