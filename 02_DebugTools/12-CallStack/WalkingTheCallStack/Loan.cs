using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
	class Loan
	{
		public Loan(string customerName)
		{
			this.CustomerName = customerName;

		}
		public string CustomerName { get; set; }
	}
}
