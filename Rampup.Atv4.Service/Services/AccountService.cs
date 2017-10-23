using Rampup.Atv4.Model;
using Rampup.Atv4.Repository;
using Rampup.Atv4.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Rampup.Atv4.Service
{
    public class AccountService : IAccountService
    {
        AccountRepository accountRepo = new AccountRepository();
        public List<Account> ListAccounts()
        {
            return accountRepo.ListAccounts();
        }

        public int AddAccount(TextBox name, TextBox pType, TextBox aType, TextBox account_ID, TextBox agency, TextBox balance)
        {
            if (string.IsNullOrEmpty(balance.Text))
                return -3;
            double dBalance = Convert.ToDouble(balance.Text);
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(pType.Text) || string.IsNullOrEmpty(aType.Text) || string.IsNullOrEmpty(account_ID.Text) || string.IsNullOrEmpty(agency.Text) || string.IsNullOrEmpty(balance.Text))
                return -1;

            if (dBalance.GetType().ToString() != "double")
                return -2;

            Account account = new Account(account_ID.Text, agency.Text, aType.Text, new Person(name.Text, pType.Text));
            account.CalcSaldo(dBalance);
            return accountRepo.AddAccount(account));
        }

        public bool UpdateAccount(string agency, string account_ID, double value)
        {
            return accountRepo.UpdateAccount(agency, account_ID, value);
        }

        public void DeleteAccount(string agency, string account_ID)
        {
            accountRepo.DeleteAccount(agency, account_ID);
        }
    }
}
