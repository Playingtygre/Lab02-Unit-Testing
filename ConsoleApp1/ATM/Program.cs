using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal balance = 1000;
            Console.WriteLine("your starting balance is");
            Console.WriteLine(balance);
            Console.ReadLine();

            UserPrompt(balance);
        }

        public static void UserPrompt(decimal balance)
        {
            Console.WriteLine("Welcome to ATM");
            Console.WriteLine("Please Select An Option");
            Console.WriteLine("1. View balance ");
            Console.WriteLine("2. make a withdraw");
            Console.WriteLine("3. deposit money");
            Console.WriteLine("4 exit");
            try
            {
                byte choice = Convert.ToByte(Console.ReadLine());
                HandleOption(choice, balance);
            }
            catch (Exception e )
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        //method for returning balance
        public static decimal ViewBalance(decimal balance)
        {
            return balance;
        }

        //method for adding balance
        public static decimal MakeDeposit(decimal deposit, decimal balance)
        {
            decimal newBalance = deposit + balance;
            Console.WriteLine($"Your balance is now ${newBalance}");
            return newBalance;

        }

        // method for withdrawing money called in the handel option
        public static decimal MakeWithdrawl(decimal amount, decimal balance)
        {
            decimal newBalance = balance - amount;
            if (newBalance < 0)
            {
                Console.WriteLine("Insufficient Funds");
                Console.WriteLine($"Your balance is currently ${balance}");
                Console.WriteLine("Transaction has been terminated");

                return balance;
            }
            if (newBalance > -1)
            {
                Console.WriteLine($"Your balance is now ${newBalance}");
            }

            return newBalance;

        }


        // user holder for val 1,2,3,4
        public static void HandleOption(byte val, decimal balance)
        {
            if (val == 1)
            {
                decimal bal = ViewBalance(balance);
                string displayBalance = bal.ToString();
                Console.WriteLine($"your balance is ${displayBalance}");
                UserPrompt(bal);
            }

            if (val == 2)
            {
                try
                {
                    Console.WriteLine("amount to withdraw");
                    decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                    if (withdraw < 1)
                    {
                        Console.WriteLine("Please enter an amount");
                        HandleOption(val, balance);
                    }
                    decimal currentBalance = MakeWithdrawl(withdraw, balance);
                    HandleOption(val, balance);
                }
                catch (Exception)
                {
                    Console.WriteLine("please enter a valid amount");
                    HandleOption(val, balance);
                  
                }

                if (val == 3)
                {
                    try
                    {
                        Console.WriteLine("How much would you like to deposit?");
                        decimal deposit = Convert.ToDecimal(Console.ReadLine());
                        if (deposit < 1)
                        {
                            Console.WriteLine("Please enter a valid amount");
                            HandleOption(val, balance);
                        }
                        decimal currentBalance = MakeDeposit(deposit, balance);     //updates the balance
                        UserPrompt(currentBalance);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter a valid amout.");
                        HandleOption(val, balance);
                    }
                }
                if (val == 0)
                {
                    Console.WriteLine("good bye");
                    Console.ReadLine();
                    }

            }
        }

    }
}
