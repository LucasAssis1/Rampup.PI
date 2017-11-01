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
            foreach (var item in accounts)
            {   //checks if it can find the specified account in the list before creating
                if(account.Agency == item.Agency && account.Account_ID == item.Account_ID)
                {
                    //found the account
                    return -2;
                }
            }
            //int accountNumber = accounts.Count;

            accounts.Add(account);
            return 1;
            
        }

        public int UpdateAccount(string agency, string account_ID, double value)
        {

            foreach (var item in accounts)
            {
                if (agency == item.Agency && account_ID == item.Account_ID)
                {
                    item.CalcSaldo(balance: value);
                    return 1;
                }
            }
            return -1;  //could not find the account in the list
        }

        public void DeleteAccount(string agency, string account_ID)
        {

        }
    }
}
