using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Create a bank account
              It should be possible to check your balance
              Withdraw and add money
              Take credit
            */
            string name;
            int money;

            Console.Write("Enter 'start' to start a process or 'q' quit: ");
            string input = Console.ReadLine();
            while (input != "start" && input != "q")
            {
                Console.WriteLine("Please enter valid action");
                input = Console.ReadLine();
            }

            if (input == "start")
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
                Console.Write("Please insert valid ammount of money: ");
                money = int.Parse(Console.ReadLine());
                var acc = new BankAcc(money, name);
                Console.Write("To continue operations press 'c' to quit press 'q': ");
                input = Console.ReadLine();
                while (input != "c" && input != "q")
                {
                    Console.WriteLine("Please enter valid action");
                    input = Console.ReadLine();
                }
                if (input == "c")
                {
                    Console.WriteLine("To add money enter 'a'\r\nTo withdraw enter 'w'\r\nTo check your balance enter 'b'\r\nTo take credit enter 'cr'\r\nTo exit press 'q'");
                    while (input != "q")
                    {
                        Console.Write("Enter action: ");
                        input = Console.ReadLine();
                        if (input == "b")
                        {
                            acc.OwnerCashBalance();
                        }
                        else if (input == "a")
                        {
                            Console.Write("Enter amount of money: ");
                            money = int.Parse(Console.ReadLine());
                            acc.InsertMoney(money);
                        }
                        else if (input == "w")
                        {
                            Console.Write("Enter amount of money to withdraw: ");
                            money = int.Parse(Console.ReadLine());
                            acc.Withdraw(money);
                        }
                        else if (input == "cr")
                        {
                            Console.Write("Enter size of the credit: ");
                            money = int.Parse(Console.ReadLine());
                            acc.TakeCredit(money);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Exiting program");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Exiting program");
                Environment.Exit(0);
            }
        }
    }
}
