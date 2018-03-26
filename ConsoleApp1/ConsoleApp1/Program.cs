using System;

namespace ConsoleApp1
{
    public class Program
    {

        public static void Main()
        {

            int amount = 1000, deposit, withdraw;
            int choice, pin = 0;
            Console.WriteLine("Enter your Pin Number");
            pin = int.Parse(Console.ReadLine());

            // if user input the correct pin this while loop executes. 
            while (true)
            {
                Console.WriteLine(" ----Welcom to the bank---- ");
                Console.WriteLine("Current Balance {0}", amount);
                Console.WriteLine("1. Check Your Balance");
                Console.WriteLine("2. Take Money out of your account");
                Console.WriteLine("3. Add money to your account ");
                Console.WriteLine("4. Exit -- Quit ");


                // 4 switch statments that allow, deduction, addition, or viewing of Balance
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    // If use press one then balance is displayed
                    case 1:
                        Console.WriteLine(" Your balance is : {0}", amount);
                        break;

                    //If user press 2 then amount is asked to make an subtraction
                    case 2:
                        Console.WriteLine("Enter The Amount to Withdraw: ");
                        withdraw = int.Parse(Console.ReadLine());

                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("Please enter Multiples of 100");
                        }

                        // user input cannot allow more than the given balance
                        else if (withdraw > (amount - 0))
                        {
                            Console.WriteLine("INSUFFICENT BALANCE");
                        }

                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine(" Please Collect Cash");
                            Console.WriteLine("Your balance is {0}", amount);
                        }
                        break;

                     // pressing 1 allows user to add money to account
                    case 3:
                        Console.WriteLine("Enter the Ammount to Deposit");
                        deposit = int.Parse(Console.ReadLine());
                        amount = deposit + amount;
                        Console.WriteLine("Your blanace is {0}", amount);
                        break;

        
                    case 4:
                        Console.WriteLine(" Thank you for using this Console ATM");
                        break;

        
                }

                Console.WriteLine("Transaction ended");

            }

        }

    }
}
