﻿using Rampup.Atv4.Model;
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
        }
        //adicionar uma camada service, com uma classe responsável por gravar os dados, deletar os dados, e atualizar os dados
        public IList<Account> RegisteredAccounts = new List<Account>();

        private void btnSend_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            string agency = txtAgency.Text;
            string account_id = txtAccount.Text;
            comboBoxAccountType.Items.Add(PersonType.Fisica);
            comboBoxAccountType.Items.Add(PersonType.Juridica);
            var pType = PersonType.Fisica;
            var aType = AccountType.Corrente;

            if (comboPersonType.Text == "Fisica")
                pType = PersonType.Fisica;
            else
                pType = PersonType.Juridica;
            if (comboBoxAccountType.Text == "Poupanca")
                aType = AccountType.Poupança;
            else
                aType = AccountType.Corrente;
            double saldo = Convert.ToDouble(txtBalance.Text);

            Person p1 = new Person(name, pType);
            Account c1 = new Account(agency, account_id ,aType, p1);

            c1.CalcSaldo(saldo);

            RegisteredAccounts.Add(c1);

            c1 = RegisteredAccounts.Last();

            txtUserName.Clear();
            txtAccount.Clear();
            txtAgency.Clear();
            txtAccount.Clear();
            txtBalance.Clear();
            comboPersonType.ResetText();
            comboBoxAccountType.ResetText();

            MessageBox.Show("Dono :" + c1.Owner.Name + "\nTipo Pessoa: " + p1.PType + "\nTipo Conta: " + c1.Type_Ac + "\nCliente desde: " + c1.CreationDate.ToShortDateString() + "\nSaldo: " + c1.Balance);
            
            //string[] row = new string[]{ c1.Owner.Name.ToString(), c1.Type_Ac.ToString(), c1.Owner.PType.ToString(), c1.Balance.ToString() };
            //var item = new ListViewItem(row);
            var item = new ListViewItem(new[] { c1.Owner.Name.ToString(), c1.Type_Ac.ToString(), c1.Owner.PType.ToString(), c1.Balance.ToString() });

            listViewAccounts.Items.Add(item);

            
        }

        private void btnConfirm_Operations_Click(object sender, EventArgs e)
        {
            string agency = txtAgency_Operations.Text;
            string account = txtAccount_Operations.Text;
            double value = Convert.ToDouble(txtValue_Operations.Text);

            if (!radioButtonCashOut_Operations.Checked ^ !radioButtonDeposit_Operations.Checked)
            {
                
            }

        }
    }
}
