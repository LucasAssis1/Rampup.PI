﻿using Rampup.Atv4.Model;
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
            int check = _service.AddAccount(txtUserName.Text, cbbPersonType.Text, cbbAccountType.Text, txtAccount.Text, txtAgency.Text, txtBalance.Text);
            switch (check)
            {
                case 1:
                    ClearInputs_Register();
                    FillListView();
                    break;
                case -1:
                    MessageBox.Show("Preencha todos os campos");
                    break;
                case -2:
                    MessageBox.Show("Valor com valor inválido. Preencher com valores numéricos");
                    break;
                case -3:
                    MessageBox.Show("Conta " + txtAccount.Text + " na agência " + txtAgency.Text + " já existe");
                    break;
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
            for(int i = 0; i < list.Count(); i++)
            {
                var item = new ListViewItem(new[] { list[i].Owner.Name.ToString(), list[i].Owner.PType.ToString(), list[i].Agency.ToString(), list[i].Account_ID.ToString(), list[i].Type_Ac.ToString(), list[i].Balance.ToString() });
                listViewAccounts.Items.Add(item);
            }
        }

        private void btnConfirm_Operations_Click(object sender, EventArgs e)
        {
            int check = _service.UpdateAccount(txtAgency_Operations.Text, txtAccount_Operations.Text, txtValue_Operations.Text, rbCashOut_Operations.Checked, rbDeposit_Operations.Checked);

            if (check == -1)
                MessageBox.Show("Preencha todos os campos");
            if (check == -2)
                MessageBox.Show("Conta " + txtAccount_Operations.Text + " na agência " + txtAgency_Operations.Text + " não foi encontrada");

            FillListView();
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
