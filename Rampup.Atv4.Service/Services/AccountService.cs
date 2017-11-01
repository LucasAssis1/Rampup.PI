using Rampup.Atv4.Model;
using Rampup.Atv4.Repository;
using Rampup.Atv4.Service.Interfaces;
using System;
using System.Collections.Generic;

namespace Rampup.Atv4.Service
{
    public class AccountService : IAccountService
    {
        AccountRepository accountRepo = new AccountRepository();
        public List<Account> ListAccounts()
        {
            return accountRepo.ListAccounts();
        }

        public int AddAccount(string name, string pType, string aType, string account_ID, string agency, string balance)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pType) || string.IsNullOrEmpty(aType) || string.IsNullOrEmpty(account_ID) || string.IsNullOrEmpty(agency) || string.IsNullOrEmpty(balance))
                return -1;  //one of the required fields is not filled

            double dBalance = Convert.ToDouble(balance);

            Account account = new Account(account_ID, agency, aType, new Person(name));
            account.CalcSaldo(dBalance);

            return accountRepo.AddAccount(account);
        }

        public int UpdateAccount(string agency, string account_ID, string value, bool cashOut, bool deposit)
        {

            if (string.IsNullOrEmpty(agency) || string.IsNullOrEmpty(account_ID) || string.IsNullOrEmpty(value) || cashOut == false && deposit == false)
                return -1;  //user did not filled the required fields

            double dBalance = Convert.ToDouble(value);

            if (cashOut)
                dBalance = -dBalance;

            int check = accountRepo.UpdateAccount(agency, account_ID, dBalance);

            if (check == -1)
                return -2; //could not find the account in the list
            return 1;
        }

        public void DeleteAccount(string agency, string account_ID)
        {
            accountRepo.DeleteAccount(agency, account_ID);
        }
    }
}
