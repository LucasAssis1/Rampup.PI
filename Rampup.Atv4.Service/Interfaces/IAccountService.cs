using Rampup.Atv4.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rampup.Atv4.Service.Interfaces
{
    interface IAccountService
    {
        List<Account> ListAccounts();
        void AddAccount(Account account);
        void UpdateAccount(string agency, string account_ID, double value);
        void DeleteAccount(string agency, string account_ID);
    }
}

