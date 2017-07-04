using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment6
{
    // Melesa_Bolt (Modified by Jason Christian - Summer 2016 Modified further by Robert Ayers 2016)
	// CSIS 209 
	// Assignment #5
	class AccountTest
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Robert Ayers Assignment 7 - CSIS 209");

			CheckingAccount Checking_1 = new CheckingAccount();
            SavingsAccount Savings_1 = new SavingsAccount();
            Boolean endLoop = false;
            Boolean loop = true;
			Boolean nextLoop = true;

			String choice;
            do
            {
                Console.WriteLine("Create Checking Account: C ");
				Console.WriteLine("Create Savings Account: S");
				Console.WriteLine("Quit the Application: Q");
                choice = Console.ReadLine();


                switch (choice.ToUpper())
				{
					case("C"):
						{
							Console.WriteLine();
							Console.WriteLine("Enter account Name");
                            Checking_1.setAccountName(Console.ReadLine());

							Console.WriteLine();
							Console.WriteLine("Enter account Number");
                            Checking_1.setAccountNumber(int.Parse(Console.ReadLine()));
							do
							{
								try
								{
									Console.WriteLine();
									Console.WriteLine("Enter an intial balance for the account");
                                    Checking_1.setBalance((Decimal)int.Parse(Console.ReadLine()));
									loop = false;
								}

								catch (NegativeNumberException error)
								{
									Console.WriteLine($"{error.Message}");
								}
							}
							while (loop);

							do
							{
								try
								{
									Console.WriteLine();
									Console.WriteLine("Enter a usage fee");
                                    int amount = int.Parse(Console.ReadLine());
                                    Checking_1.setFeeCharged((decimal) amount);
									nextLoop = false;
								}
								catch (NegativeNumberException error)
								{
									Console.WriteLine($"{error.Message}");
								}
							}
							while (nextLoop);

						}
						break;
					case "S":
                        {
							Console.WriteLine();
							Console.WriteLine("Enter account Name");
                            Savings_1.setAccountName(Console.ReadLine());

							Console.WriteLine();
							Console.WriteLine("Enter account Number");
                            Savings_1.setAccountNumber(int.Parse(Console.ReadLine()));
                            do
                            {
							 try
                                {
									Console.WriteLine();
									Console.WriteLine("Enter an intial balance for the account");
                                    Savings_1.setBalance((Decimal)int.Parse(Console.ReadLine()));
                                    loop = false;
								}

							catch (NegativeNumberException error)
								{
									Console.WriteLine($"{error.Message}");
								}
                            }
                            while (loop);

                            do
                            {
								try
								{
									Console.WriteLine();
									Console.WriteLine("Enter an interest rate greater than 0.0");
                                    double amount = Double.Parse(Console.ReadLine());
									Savings_1.setInterestRate(amount);
                                    nextLoop = false;
								}
								catch (NegativeNumberException error)
								{
									Console.WriteLine($"{error.Message}");
								}
                            }
                            while (nextLoop);

                        }
						break;
					case "Q":
                        endLoop = true;
						break;
					default:
						endLoop = true;
						break;
				}

            }
            while (!endLoop);
			
		}
	}
}
