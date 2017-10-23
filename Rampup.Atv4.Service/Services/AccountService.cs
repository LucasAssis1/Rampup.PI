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

        public bool AddAccount(Account account)
        {
            return accountRepo.AddAccount(account);
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
