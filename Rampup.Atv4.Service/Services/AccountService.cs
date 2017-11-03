using Rampup.Atv4.Commom;
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

        public void AddAccount(string name, string personType, string accountType, string account_ID, string agency, string balance)
        {

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(personType) || string.IsNullOrEmpty(accountType) || string.IsNullOrEmpty(account_ID) || string.IsNullOrEmpty(agency) || string.IsNullOrEmpty(balance))
                throw new FieldsNotFilledException("Preencha todos os campos");
                //return -1;  //one of the required fields is not filled

            double dBalance = Convert.ToDouble(balance);
            //test
            Account account = new Account(account_id: account_ID, agency: agency, accountType: accountType, owner: new Person(name));
            account.CalcSaldo(balance: dBalance);

            accountRepo.AddAccount(account);
        }

        public void UpdateAccount(string agency, string account_ID, string value, bool cashOut, bool deposit)
        {

            if (string.IsNullOrEmpty(agency) || string.IsNullOrEmpty(account_ID) || string.IsNullOrEmpty(value) || cashOut == false && deposit == false)
                throw new FieldsNotFilledException("Preencha todos os campos");

            double dBalance = Convert.ToDouble(value);

            if (cashOut)
                dBalance = -dBalance;

            accountRepo.UpdateAccount(agency: agency, account_ID: account_ID, value: dBalance);
        }

        public void DeleteAccount(string agency, string account_ID)
        {
            accountRepo.DeleteAccount(agency: agency, account_ID: account_ID);
        }
    }
}
