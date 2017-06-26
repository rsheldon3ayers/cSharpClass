using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_5
{
	class Account
	{
		// Melesa_Bolt
		// BMIS_209_Spring_2012
		// Assignment #5

		private decimal Balance;
		private string AccountName;
		private int AccountNumber;


		//Construtor 
		public Account(string acct_name, int acct_number, decimal acct_balance)
		{
			setAccountName(acct_name);
			setBalance(acct_balance);
			setAccountNumber(acct_number);

		}

		//Mutator method to set account name.
		public void setAccountName(string acct_name)
		{
			AccountName = acct_name;
		}
		//Accessor method to get account name
		public string getAccountName()
		{
			return AccountName;
		}

		//Mutator method to set account number.
		public void setAccountNumber(int acct_number)
		{
			AccountNumber = acct_number;
		}
		//Accessor method to get account number
		public int getAccountNumber()
		{
			return AccountNumber;
		}
		//Mutator method to set account balance.
		public void setBalance(decimal acct_balance)
		{
			if (acct_balance < 0)
			{
				Balance = 0.0M;
			}
			else
			{
				Balance = acct_balance;
			}
		}
		//Accessor method to get account balance
		public decimal getBalance()
		{
			return Balance;
		}
		//Method to make deposits
		public virtual void Credit(decimal amount)
		{
			Balance += amount;

		}
		//Method to make withdrawals
		public virtual bool Debit(decimal amount)
		{
			if (amount > Balance)
			{
				Console.WriteLine("Insufficient funds");
				return false;
			}
			else
			{
				Balance -= amount;
				return true;
			}
		}
		//Method to print account information
		public virtual void PrintAccount()
		{
			Console.WriteLine("Account Name: " + AccountName);
			Console.WriteLine("Account Number: " + AccountNumber);
			Console.WriteLine("Balance:  {0:C}", Balance);

		}

	}
}
