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
        int AddAccount(TextBox name, TextBox pType, TextBox aType, TextBox account_ID, TextBox agency, TextBox balance);
        bool UpdateAccount(string agency, string account_ID, double value);
        void DeleteAccount(string agency, string account_ID);
    }
}

