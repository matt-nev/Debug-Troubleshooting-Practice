using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
  class Financial
  {
   
   

    public static decimal CreateLoan(string customerName, decimal loanAmount)
    {
      var loan = new Loan(customerName);
      return loanAmount * GetCurrentLoanRate();

    }

		public static decimal GetCurrentLoanRate()
		{
			var currentFederalRate = BankLib.OnlineServices.GetBankRateFromSystem();
			var newRate = currentFederalRate + BankLib.OnlineServices.GetLoanFee();
			return newRate;

		}
  }
}
