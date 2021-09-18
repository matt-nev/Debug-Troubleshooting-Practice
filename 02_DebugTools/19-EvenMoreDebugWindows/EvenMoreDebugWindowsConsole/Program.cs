using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenMoreDebugWindowsConsole
{
	class Program
	{
		static void Main(string[] args) {
			int x;
			x = 3;
			Console.WriteLine(x);
			x = 7;

			Console.WriteLine(x);

			var numbers = new List<int> { 10, 20, 40, 90, 50, 120, 30 };

			// Use of the LINQ classes
			// causes the runtime to load the additional assemblies
			// because Enumerable.OrderBy() is in System.Core.dll


			 var sortedNumbers = numbers.OrderBy(v => v).ToList();


		}
	}
}
