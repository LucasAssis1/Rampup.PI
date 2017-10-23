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
        AccountService _service;
        public Form1()
        {
            InitializeComponent();
            _service = new AccountService();
            dataGridAccounts.Hide();
        }
        
        //adicionar uma camada service, com uma classe responsável por gravar os dados, deletar os dados, e atualizar os dados
        //public List<Account> RegisteredAccounts = new List<Account>();
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
            
            bool check =_service.AddAccount(c1);
            List<Account> list = _service.ListAccounts();
            
            txtUserName.Clear();
            txtAccount.Clear();
            txtAgency.Clear();
            txtAccount.Clear();
            txtBalance.Clear();
            comboPersonType.ResetText();
            comboBoxAccountType.ResetText();

            dataGridAccounts.DataSource = null;
            dataGridAccounts.DataSource = list;

            listViewAccounts.Items.Clear();

            foreach (var i in list)
            {
                var item = new ListViewItem(new[] { i.Owner.Name.ToString(), i.Type_Ac.ToString(), i.Owner.PType.ToString(), i.Balance.ToString() });
                listViewAccounts.Items.Add(item);
            }

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
            listViewAccounts.Items.Clear();


            List<Account> list = _service.ListAccounts();
            foreach (var i in list)
            {
                var item = new ListViewItem(new[] { i.Owner.Name.ToString(), i.Type_Ac.ToString(), i.Owner.PType.ToString(), i.Balance.ToString() });
                listViewAccounts.Items.Add(item);
            }
        }
    }
}
