using Rampup.Atv4.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rampup.Atv4.Service.Interfaces
{
    interface IAccountService
    {
        List<Account> ListAccounts();
        bool AddAccount(Account account);
        bool UpdateAccount(string agency, string account_ID, double value);
        void DeleteAccount(string agency, string account_ID);
    }
}

