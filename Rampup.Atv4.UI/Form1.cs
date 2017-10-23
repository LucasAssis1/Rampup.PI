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
            cbbAccountType.DataSource = Enum.GetValues(typeof(AccountType));
            cbbPersonType.DataSource = Enum.GetValues(typeof(PersonType));
        }

        //adicionar uma camada service, com uma classe responsável por gravar os dados, deletar os dados, e atualizar os dados
        //public List<Account> RegisteredAccounts = new List<Account>();
        private void btnSend_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            string agency = txtAgency.Text;
            string account_id = txtAccount.Text;

            string pType = cbbPersonType.Text;
            string aType = cbbAccountType.Text;
            
            if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(agency) && !String.IsNullOrEmpty(account_id) && txtBalance.Text != null)
            {
                double balance = Convert.ToDouble(txtBalance.Text);
                Person p1 = new Person(name, pType);
                Account c1 = new Account(account_id, agency, aType, p1);

                c1.CalcSaldo(balance);

                bool check = _service.AddAccount(c1);
                List<Account> list = _service.ListAccounts();

                txtUserName.Clear();
                txtAccount.Clear();
                txtAgency.Clear();
                txtAccount.Clear();
                txtBalance.Clear();
                cbbPersonType.ResetText();
                cbbAccountType.ResetText();
                
                listViewAccounts.Items.Clear();

                for(int i = 0; i < list.Count(); i++)
                {
                    var item = new ListViewItem(new[] { list[i].Owner.Name.ToString(), list[i].Account_ID.ToString(),list[i].Agency.ToString() ,list[i].Type_Ac.ToString(), list[i].Owner.PType.ToString(), list[i].Balance.ToString() });
                    listViewAccounts.Items.Add(item);
                }

                //foreach (var i in list)
                //{
                //    var item = new ListViewItem(new[] { i.Owner.Name.ToString(), i.Type_Ac.ToString(), i.Owner.PType.ToString(), i.Balance.ToString() });
                //    listViewAccounts.Items.Add(item);
                //}
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void btnConfirm_Operations_Click(object sender, EventArgs e)
        {
            string agency = txtAgency_Operations.Text;
            string account = txtAccount_Operations.Text;
            double value = Convert.ToDouble(txtValue_Operations.Text);
            bool check;
            if (radioButtonCashOut_Operations.Checked)
            {
                check = _service.UpdateAccount(agency, account, -value);
            }
            else if (radioButtonDeposit_Operations.Checked)
            {
               check = _service.UpdateAccount(agency, account, value);
            }        
            
            txtAgency_Operations.Clear();
            txtAccount_Operations.Clear();
            txtValue_Operations.Clear();
            radioButtonCashOut_Operations.Checked = false;
            radioButtonDeposit_Operations.Checked = false;
            listViewAccounts.Items.Clear();

            //string[] showList = new string[]
            List<Account> list = _service.ListAccounts();
            foreach (var i in list)
            {
                var item = new ListViewItem(new[] { i.Owner.Name.ToString(), i.Agency.ToString(), i.Account_ID.ToString(), i.Type_Ac.ToString(), i.Owner.PType.ToString(), i.Balance.ToString() });
                listViewAccounts.Items.Add(item);
            }
        }
    }
}
