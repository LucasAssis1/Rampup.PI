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
using static Rampup.Atv4.Commom.Enums;

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

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                //passing named parameters to the addAccount method in AccountService
                _service.AddAccount(name: txtUserName.Text, personType: cbbPersonType.Text, accountType: cbbAccountType.Text, account_ID: txtAccount.Text, agency: txtAgency.Text, balance: txtBalance.Text);
                ClearInputs_Register();
                FillListView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearInputs_Register()
        {
            txtUserName.Clear();
            txtAccount.Clear();
            txtAgency.Clear();
            txtAccount.Clear();
            txtBalance.Clear();
        }

        private void FillListView()
        {
            listViewAccounts.Items.Clear();

            List<Account> list = _service.ListAccounts();
            int listCount = list.Count();
            for(int i = 0; i < listCount; i++)
            {
                var item = new ListViewItem(new[] { list[i].Owner.Name.ToString(), list[i].Agency.ToString(), list[i].Account_ID.ToString(), list[i].AccountType.ToString(), list[i].Balance.ToString() });
                listViewAccounts.Items.Add(item);
            }
        }

        private void btnConfirm_Operations_Click(object sender, EventArgs e)
        {
            try
            {
                _service.UpdateAccount(txtAgency_Operations.Text, txtAccount_Operations.Text, txtValue_Operations.Text, rbCashOut_Operations.Checked, rbDeposit_Operations.Checked);
                ClearInputs_Operations();
                FillListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearInputs_Operations()
        {
            txtAgency_Operations.Clear();
            txtAccount_Operations.Clear();
            txtValue_Operations.Clear();
            rbCashOut_Operations.Checked = false;
            rbDeposit_Operations.Checked = false;
        }
    }
}
