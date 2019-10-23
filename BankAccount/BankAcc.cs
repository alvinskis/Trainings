using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class BankAcc
    {
        List<KeyValuePair<string, int>> accountsList = new List<KeyValuePair<string, int>>();
        public int CashBalance { get; set; }
        public string Owner { get; set; }
        public BankAcc(int cashBalance, string owner)
        {
            CashBalance = cashBalance;
            Owner = owner;
        }

        public void OwnerCashBalance()
        {
            Console.WriteLine($"{Owner}, your balance is: {CashBalance}");
            accountsList.Add(new KeyValuePair<string, int>(Owner, CashBalance));
        }

        public void ListOfAccounts()
        {
            foreach (var acc in accountsList)
            {
                Console.WriteLine(acc);
            }
        }

        public void InsertMoney(int money)
        {
            CashBalance += money;
            Console.WriteLine($"You have successfuly added {money} to your bank account");
        }

        public void Withdraw(int money)
        {
            if (money > CashBalance)
            {
                Console.WriteLine("You do not have enough money, you poor bastard");
            }
            else
            {
                CashBalance -= money;
                Console.WriteLine($"You have successfuly withdrawed {money} from your bank account");
            }
        }

        public void TakeCredit(int money)
        {
            if (CashBalance < 1500)
            {
                Console.WriteLine("You can't take credit you poor basterd, come back when you will have more than 1500");
            }
            else
            {
                Console.WriteLine($"You have take credit of {money}, 12% of credit sum will be charged from your account balance");
                if (money * 88 / 100 > CashBalance)
                {
                    Console.WriteLine("You can't take that big credit");
                }
                else
                {
                    CashBalance -= money * 88 / 100;
                    OwnerCashBalance();
                }
            }
        }
    }
}
