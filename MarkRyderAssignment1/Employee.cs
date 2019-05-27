using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkRyderAssignment1
{
	class Employee
	{
		///<summary>The rate of pay of employee</summary>
		private double rate;

		///<summary>The number of hours worked in a week</summary>
		private double hours;

		///<summary>The full name of the employee</summary>
		private string name;

		///<summary>The current tax rate</summary>
		private static double taxRate = 0.15;

		///<summary>Total earnings for the week</summary>
		private double grossEarnings;

		///<summary>The takehome earnings after tax deducted</summary>
		private double netEarnings;

		///<summary>The total tax paid in the week</summary>
		private double taxPaid;

		///<summary>Value determines of pay has already been calculated</summary>
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
			Rate = rate;
			Name = name;
			Hours = hours;
		}

		/// <summary>
		/// Calculates the gross earnings, tax to be paid
		/// and net earnings of the current employee
		/// </summary>
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
