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

        public int AddAccount(string name, string personType, string accountType, string account_ID, string agency, string balance)
        {

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(personType) || string.IsNullOrEmpty(accountType) || string.IsNullOrEmpty(account_ID) || string.IsNullOrEmpty(agency) || string.IsNullOrEmpty(balance))
                throw new FieldsNotFilledException();
                //return -1;  //one of the required fields is not filled

            double dBalance = Convert.ToDouble(balance);

            Account account = new Account(account_id: account_ID, agency: agency, accountType: accountType, owner: new Person(name));
            account.CalcSaldo(balance: dBalance);

            return accountRepo.AddAccount(account);
        }

        public int UpdateAccount(string agency, string account_ID, string value, bool cashOut, bool deposit)
        {

            if (string.IsNullOrEmpty(agency) || string.IsNullOrEmpty(account_ID) || string.IsNullOrEmpty(value) || cashOut == false && deposit == false)
                throw new FieldsNotFilledException();
                //return -1;  //user did not filled the required fields

            double dBalance = Convert.ToDouble(value);

            if (cashOut)
                dBalance = -dBalance;

            int check = accountRepo.UpdateAccount(agency: agency, account_ID: account_ID, value: dBalance);

            if (check == -1)
                return -2; //could not find the account in the list
            return 1;
        }

        public void DeleteAccount(string agency, string account_ID)
        {
            accountRepo.DeleteAccount(agency: agency, account_ID: account_ID);
        }
    }
}
