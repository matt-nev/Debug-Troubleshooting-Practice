using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugPhilosophy {
	static class BugA {

		public static void ShowBug() {



			decimal finalResult = 0;
			decimal saleAmountWithMarkup = 0;
			decimal saleAmount = 120.00M;
			decimal markupRate = 1.15M;
			decimal taxRate = .05M;

			// expected result (120 * 1.15)* 1.05 == 144.90


			saleAmountWithMarkup = saleAmount * markupRate;
			finalResult = CalculateTotalSale(markupRate, taxRate);  // this is wrong

			saleAmountWithMarkup = 0;

			// another bug
			saleAmountWithMarkup = saleAmount * markupRate;

			
			finalResult = CalculateTotalSale(taxRate, saleAmountWithMarkup);

			// this reason for the error is easier to understand 
			// changing the coding style
			// use named parameters

			saleAmountWithMarkup = saleAmount * markupRate;
			finalResult = CalculateTotalSale(grossSale: taxRate,
																			 taxRate: saleAmountWithMarkup);


		}


		static decimal CalculateTotalSale(decimal grossSale, decimal taxRate) {
			return grossSale * (1M + taxRate);
		}

	}
}
