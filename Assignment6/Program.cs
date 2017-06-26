using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_5
{
	// Melesa_Bolt (Modified by Jason Christian - Summer 2016
	// CSIS 209 
	// Assignment #5
	class AccountTest
	{
		static void Main(string[] args)
		{

            Account[] accounts = new Account[4];

            SavingsAccount Savings_1 = new SavingsAccount("Ayers-Savings", 1, 1000, .04);
			SavingsAccount Savings_2 = new SavingsAccount("Ayers-Savings", 2, 2000, .05);

			CheckingAccount Checking_1 = new CheckingAccount("Ayers-Checking", 3, 3000, 3.00M);
			CheckingAccount Checking_2 = new CheckingAccount("Ayers-Checking", 4, 4000, 4.00M);

            accounts[0] = Savings_1;
            accounts[1] = Savings_2;
            accounts[2] = Checking_1;
            accounts[3] = Checking_2;


            foreach (Account account in accounts)
            {
                account.PrintAccount();

                Console.WriteLine($"Enter an ammount you would like to withdraw from {account.getAccountName()}");

                account.Debit(int.Parse(Console.ReadLine()));

				account.PrintAccount();

			}
			
			Console.WriteLine();
			Console.WriteLine("Press the [Enter] key to continue.");
			Console.ReadLine();
		}
	}
}
