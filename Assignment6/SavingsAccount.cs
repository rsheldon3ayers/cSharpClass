using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_5
{
	class SavingsAccount : Account
	{
		private double InterestRate;

		//Constructor
		public SavingsAccount(string acct_name, int acct_number, decimal acct_balance, double int_rate)
			: base(acct_name, acct_number, acct_balance)
		{
			setInterestRate(int_rate);
		}

		//Mutator to set the interest rate
		public void setInterestRate(double rate)
		{
			if (rate < 0)
			{
				InterestRate = 0.0;
			}
			else
			{
				InterestRate = rate;
			}
		}

		//Accessor to get the interest rate
		public double getInterestRate()
		{
			return InterestRate;
		}

		public void CalculateInterest()
		{
			setBalance(getBalance() + getBalance() * (decimal)(getInterestRate()));
		}

		public override void PrintAccount()
		{
			base.PrintAccount();
			Console.WriteLine("Interest rate: " + getInterestRate() * 100 + "%");
			Console.WriteLine();
		}
	}
}
