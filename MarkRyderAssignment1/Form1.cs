using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkRyderAssignment1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			UpdateUi();
			this.StartPosition = FormStartPosition.CenterScreen;
			this.MinimumSize = new Size(300,500);
		}

		/// <summary>Employee to be displayed on the form</summary>
		Employee employee;
		/// <summary>List of employees of the current session</summary>
		List<Employee> employeeList = new List<Employee>();

		/// <summary>
		/// Takes the values inside the text boxes and calculates weekly wage
		/// </summary>
		private void btnCalculate_Click(object sender, EventArgs e)
		{
			if (employee == null)
			{
				try
				{
					if (IsDuplicateEmployee(txtName.Text))
					{
						throw new Exception("Employee Already Exists");
					}

					ParseTextBoxes();

					employee = new Employee
						(
						txtName.Text,
						Convert.ToDouble(txtRate.Text),
						Convert.ToDouble(txtHours.Text)
						);

					employee.CalculateEarnings();

					txtGross.Text = employee.GrossEarnings.ToString();
					txtTaxes.Text = employee.TaxPaid.ToString();
					txtNet.Text = employee.NetEarnings.ToString();

					AddEmployeeToComboBox(employee);
					employeeList.Add(employee);

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else
			{
				employee.CalculateEarnings();

				//if (IsDuplicateEmployee(txtName.Text))
				//{
				//	employee
				//}

				txtGross.Text = employee.GrossEarnings.ToString();
				txtTaxes.Text = employee.TaxPaid.ToString();
				txtNet.Text = employee.NetEarnings.ToString();
			}


			//TODO - add to resources all strings entered


		}

		/// <summary>
		/// Performs validation of the textboxes and throws appropriate exception message
		/// </summary>
		private void ParseTextBoxes()
		{
			var sRate = txtRate.Text;
			if (!Double.TryParse(sRate, out double rate))
			{
				txtRate.Focus();
				throw new Exception("Hourly rate is not in proper format");
			}

			var sHours = txtHours.Text;
			if (!Double.TryParse(sHours, out double hours))
			{
				txtHours.Focus();
				throw new Exception("Hours worked is not in proper format");
			}

			if (rate < 15)
			{
				throw new Exception("Rate cannot be below minimum wage");
			}
			if (hours < 0 || hours > 168)
			{
				throw new Exception("Hours are not within proper range");
			}
		}

		/// <summary>
		/// Adds the name of the employee object in parameter to the combobox dropdown menu
		/// </summary>
		/// <param name="emp">Employee object</param>
		private void AddEmployeeToComboBox(Employee emp)
		{
			cmbEmployees.Items.Add(emp.Name);
		}

		/// <summary>
		/// Checks whether an employee with that name already exists
		/// </summary>
		/// <param name="name">Name to be tested</param>
		private bool IsDuplicateEmployee(string name)
		{
			bool isDuplicate = false;
			foreach (Employee emp in employeeList)
			{
				if (emp.Name.Equals(name))
				{
					isDuplicate = true;
					break;
				}
			}

			return isDuplicate;
		}



		private void UpdateUi()
		{
			if (employee == null)
			{
				txtGross.Enabled = false;
				txtTaxes.Enabled = false;
				txtNet.Enabled = false;
			}
		}

		/// <summary>
		/// Fetches an employee object that matches the given names
		/// </summary>
		/// <param name="name">Name of employee to be fetched</param>
		private Employee GetEmployee(string name)
		{
			//TODO - update to index of?

			foreach (Employee emp in employeeList)
			{
				if (emp.Name.Equals(name))
				{
					return emp;
				}
			}

			return null;
		}

		/// <summary>
		/// Fills the textboxes when user selects employee from combobox dropdown
		/// </summary>
		private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
		{
			 employee = GetEmployee(cmbEmployees.SelectedItem.ToString());

			txtName.Text = employee.Name;
			txtRate.Text = employee.Rate.ToString();
			txtHours.Text = employee.Hours.ToString();

		}

		/// <summary>
		/// Clears all textboxes in the application and makes employee object null
		/// </summary>
		private void btnClear_Click(object sender, EventArgs e)
		{
			employee = null;
			txtName.Text = "";
			txtRate.Text = "";
			txtHours.Text = "";

			txtNet.Text = "";
			txtTaxes.Text = "";
			txtGross.Text = "";

		}





		/// <summary>
		/// Asks for confirmation before closing the application
		/// </summary>
		private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				var result = MessageBox.Show
					(
					"Are you sure you want to exit?", 
					"Confirm Close", 
					MessageBoxButtons.YesNo
					);
				if (result == DialogResult.Yes)
				{
					Application.Exit();
				}
				else
				{
					e.Cancel = true;
				}
			}
		}
	}
}
