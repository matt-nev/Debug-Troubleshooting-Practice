using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploringBreakpoints
{
  class Financial
  {
    public static decimal CalculateMonthlyPayment(int numberOfMonths, decimal loanRate, decimal loanAmount)
    { 
    // simplified formula
      decimal result ;
      // bug here, because I forgot to use the loanRate
      result = loanAmount / numberOfMonths;

      return result;

    }
  }
}
