using Rampup.Atv4.Commom.Exceptions;
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

        public void AddAccount(Account account)
        {
            foreach (var item in accounts)
            {   //checks if it can find the specified account in the list before creating
                if(account.Agency == item.Agency && account.Account_ID == item.Account_ID)
                {
                    //found the account
                    throw new ExistingAccountException($"Conta {account.Account_ID} na agência {account.Agency} já existe");
                }
            }

            accounts.Add(account);
        }

        public int UpdateAccount(string agency, string account_ID, double value)
        {

            foreach (var item in accounts)
            {
                if (agency == item.Agency && account_ID == item.Account_ID)
                {
                    item.CalcSaldo(balance: value);
                }
            }
            throw new UnexistingAccountException($"Conta {account_ID} na agência {agency} não foi encontrada");
        }

        public void DeleteAccount(string agency, string account_ID)
        {

        }
    }
}
