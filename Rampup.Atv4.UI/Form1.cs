using Rampup.Atv4.Model;
using Rampup.Atv4.Service;
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
            //comboBoxAccountType.Items.Add(PersonType.Fisica.ToString());
            //comboBoxAccountType.Items.Add(PersonType.Juridica.ToString());
        }

        //adicionar uma camada service, com uma classe responsável por gravar os dados, deletar os dados, e atualizar os dados
        //public List<Account> RegisteredAccounts = new List<Account>();
        AccountService _service = new AccountService();
        private void btnSend_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            string agency = txtAgency.Text;
            string account_id = txtAccount.Text;
            
            var pType = PersonType.Fisica;
            var aType = AccountType.Corrente;

            if (comboPersonType.Text == "Física")
                pType = PersonType.Fisica;
            else
                pType = PersonType.Juridica;
            if (comboBoxAccountType.Text == "Poupança")
                aType = AccountType.Poupança;
            else
                aType = AccountType.Corrente;
            double saldo = Convert.ToDouble(txtBalance.Text);

            Person p1 = new Person(name, pType);
            Account c1 = new Account(account_id, agency, aType, p1);
           
            c1.CalcSaldo(saldo);

            //RegisteredAccounts.Add(c1);
            bool check =_service.AddAccount(c1);
            List<Account> list = _service.ListAccounts();
            
            txtUserName.Clear();
            txtAccount.Clear();
            txtAgency.Clear();
            txtAccount.Clear();
            txtBalance.Clear();
            comboPersonType.ResetText();
            comboBoxAccountType.ResetText();

            //MessageBox.Show("Dono :" + c1.Owner.Name + "\nTipo Pessoa: " + p1.PType + "\nTipo Conta: " + c1.Type_Ac + "\nCliente desde: " + c1.CreationDate.ToShortDateString() + "\nSaldo: " + c1.Balance);

            //string[] row = new string[]{ c1.Owner.Name.ToString(), c1.Type_Ac.ToString(), c1.Owner.PType.ToString(), c1.Balance.ToString() };
            //var item = new ListViewItem(row);

            //IDictionary<String, Object> dictAccount = new Dictionary<String, Object>();
            //for(int i = 0; i< list.Count; i++)
            //{
            //    dictAccount.Add("Nome", list[i].Owner.Name);
            //    dictAccount.Add("Agência", list[i].Agency);
            //    dictAccount.Add("Conta", list[i].Account_ID);
            //    dictAccount.Add("Saldo", list[i].Balance);
            //}

            dataGridAccounts.DataSource = null;
            dataGridAccounts.DataSource = _service.ListAccounts();
            
            //dataGridAccounts.Columns.Add("Dg_Name", "Nome");
            

            var item = new ListViewItem(new[] { c1.Owner.Name.ToString(), c1.Type_Ac.ToString(), c1.Owner.PType.ToString(), c1.Balance.ToString() });

            //listViewAccounts.Items.Add(item);

            
        }

        private void btnConfirm_Operations_Click(object sender, EventArgs e)
        {
            string agency = txtAgency_Operations.Text;
            string account = txtAccount_Operations.Text;
            double value = Convert.ToDouble(txtValue_Operations.Text);

            if (radioButtonCashOut_Operations.Checked)
            {
                _service.UpdateAccount(agency, account, -value);
            }
            else if (radioButtonDeposit_Operations.Checked)
            {
                _service.UpdateAccount(agency, account, value);
            }

            dataGridAccounts.DataSource = null;
            dataGridAccounts.DataSource = _service.ListAccounts();

            txtAgency_Operations.Clear();
            txtAccount_Operations.Clear();
            txtValue_Operations.Clear();
            radioButtonCashOut_Operations.Checked = false;
            radioButtonDeposit_Operations.Checked = false;
        }
    }
}
