using Rampup.Atv4.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rampup.Atv4.Service.Interfaces
{
    interface IAccountService
    {
        List<Account> ListAccounts();
        void AddAccount(string name, string pType, string aType, string account_ID, string agency, string balance);
        void UpdateAccount(string agency, string account_ID, string value, bool cashOut, bool deposit);
        void DeleteAccount(string agency, string account_ID);
    }
}

