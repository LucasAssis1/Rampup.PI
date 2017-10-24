using Rampup.Atv4.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Rampup.Atv4.Service.Interfaces
{
    interface IAccountService
    {
        List<Account> ListAccounts();
        int AddAccount(string name, string pType, string aType, string account_ID, string agency, string balance);
        int UpdateAccount(string agency, string account_ID, string value, bool operation);
        void DeleteAccount(string agency, string account_ID);
    }
}

