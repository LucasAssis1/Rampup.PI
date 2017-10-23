using Rampup.Atv4.Model;
using System;
using System.Collections.Generic;

namespace Rampup.Atv4.Repository
{
    public class AccountRepository
    {
        List<Account> accounts = new List<Account>();

        public List<Account> ListAccounts()
        {
            return accounts;
        }

        public int AddAccount(Account account)
        {
            int accountNumber = accounts.Count;
            accounts.Add(account);

            if (accounts.Count > accountNumber)
                return 1;
            return -1;
        }

        public bool UpdateAccount(string agency, string account_ID, double value)
        {

            foreach (var item in accounts)
            {
                if (agency == item.Agency && account_ID == item.Account_ID)
                {
                    item.CalcSaldo(value);
                    return true;
                }
            }
            return false;
        }

        public void DeleteAccount(string agency, string account_ID)
        {

        }
    }
}
