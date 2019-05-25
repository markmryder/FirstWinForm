using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkRyderAssignment1
{
	class Employee
	{
		private double rate;
		private double hours;
		private string name;

		private static double taxRate = 0.15;

		private double grossEarnings;
		private double netEarnings;
		private double taxPaid;

		private bool isCalculated;

		public double Rate { get => rate; set => rate = value; }
		public double Hours { get => hours; set => hours = value; }
		public string Name { get => name; set => name = value; }
		public double GrossEarnings { get => grossEarnings; }
		public double NetEarnings { get => netEarnings; }
		public double TaxPaid { get => taxPaid; }

		public bool IsCalculated { get => isCalculated; set =>isCalculated = value; }

		public Employee(string name, double rate, double hours)
		{
			//if () { }
			//if () { }
			//if () { }

			Rate = rate;
			Name = name;
			Hours = hours;
		}


		public void CalculateEarnings()
		{

			if (hours <= 40)
			{
				grossEarnings = rate * hours;
				taxPaid = grossEarnings * taxRate;
				netEarnings = grossEarnings - taxPaid;
			}
			else
			{
				grossEarnings = (40 * rate) + ((hours - 40) * rate * 1.5);
				taxPaid = grossEarnings * taxRate;
				netEarnings = grossEarnings - taxPaid;
			}
			
		}

	}
}
