using System;

namespace ConsoleApp1
{
    public class Program
    {

        public static void Main()
        {
                decimal currentBalance = 1000;
                bool sessionActive = true;

                Console.WriteLine("Welcome to the automated teller machine!");

                // Run a finite state machine until the user chooses to exit
                while (sessionActive)
                {
                    DisplayMenu();

                    switch (Console.ReadKey(true).KeyChar)
                    {
                        case '1':
                            currentBalance = WithdrawPrompt(currentBalance);
                            break;
                        case '2':
                            currentBalance = DepositPrompt(currentBalance);
                            break;
                        case '3':
                            Console.WriteLine($"\nYour current balance is {ViewBalance(currentBalance)}");
                            break;
                        case '4':
                            sessionActive = false;
                            break;
                        default:
                            continue;
                    }
                }
           

        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nPlease choose an option below:");
            Console.WriteLine("1) Withdraw Funds");
            Console.WriteLine("2) Deposit Funds");
            Console.WriteLine("3) View Account Balance");
            Console.WriteLine("4) End Session");
        }

        
        static decimal ReadUserDecimal()
        {
            decimal amount;

            for (; ; )
            {
                try
                {
                    amount = Convert.ToDecimal(Console.ReadLine());
                }
                catch (OverflowException)
                {
                    Console.WriteLine("user entered a small number");
                    Console.WriteLine("Please type in a number");
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Could not understand User input");
                }

                /*if (amount >= 0x0)
                {
                    break;
                }*/

                Console.WriteLine("Please try again");
            }
            return amount;

        }

        static decimal WithdrawPrompt(decimal currentBalance)
        {
            Console.WriteLine($"\nYour current balance is {ViewBalance(currentBalance)}");
            Console.WriteLine("How much would you like to withdraw?");
            Console.WriteLine("Please only type numbers and decimal points.");

            try
            {
                return WithdrawFunds(currentBalance, ReadUserDecimal());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                return currentBalance;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return currentBalance;
            }
        }

        private static decimal WithdrawFunds(decimal currentBalance, decimal v)
        {
            throw new NotImplementedException();
        }

        static decimal DepositPrompt(decimal currentBalance)
        {
            Console.WriteLine("\nHow much would you like to deposit?");
            Console.WriteLine("Please only type numbers and decimal points.");

            try
            {
                return DepositFunds(currentBalance, ReadUserDecimal());
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return currentBalance;
            }
        }

        private static decimal DepositFunds(decimal currentBalance, decimal v)
        {
            throw new NotImplementedException();
        }

        ///dispalying your account
        public static string ViewBalance(decimal currentBalance) 
            {
            return currentBalance.ToString("C");
            }


       // this method withdraws money from the account//
        public static decimal Withdraw(decimal currentBalance, decimal withdrawNumber)
        {
            if (withdrawNumber < 0)
            {
                throw new ArgumentOutOfRangeException(" No");
            }
            if (withdrawNumber > currentBalance)
            {
                throw new InvalidOperationException("unable to perform");
            }

            return currentBalance - withdrawNumber;
        }


        // adding a deposit
        public static decimal DepositMoney(decimal currentBalance, decimal depositNumber)
        {
            if (depositNumber < 0)
            {
                throw new ArgumentOutOfRangeException("No");
            }
            return currentBalance + depositNumber;
        }
    }

}
