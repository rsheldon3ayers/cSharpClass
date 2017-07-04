using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment6
{
	class CheckingAccount : Account
	{
		private decimal FeeCharged;

        public CheckingAccount()
        {
            
        }
		//Constructor
		public CheckingAccount(string acct_name, int acct_number, decimal acct_balance, decimal fee)
			: base(acct_name, acct_number, acct_balance)
		{
			setFeeCharged(fee);
		}

		//Mutator to set the interest rate
		public void setFeeCharged(decimal fee)
		{
			if (fee < 0)
			{
                throw new NegativeNumberException();
			}
			else
			{
				FeeCharged = fee;
			}
		}

		//Accessor to get the interest rate
		public decimal getFeeCharged()
		{
			return FeeCharged;
		}

		public override bool Debit(decimal amount)
		{
			if (base.Debit(amount))
			{
				setBalance(getBalance() - getFeeCharged());
				return true;
			}
			else
			{
				return false;
			}
		}

		public override void Credit(decimal amount)
		{
			base.Credit(amount);
			setBalance(getBalance() - getFeeCharged());
		}

		public override void PrintAccount()
		{
			base.PrintAccount();
			Console.WriteLine("Fee charged:  {0:C} ", FeeCharged);
			Console.WriteLine();
		}
	}
}
