using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


		/// <summary>List of error messages from resources</summary>
		private string app_close_msg = Properties.Resources.APP_CLOSE_MSG;
		private string app_close_cap = Properties.Resources.APP_CLOSE_CAPTION;
		private string err_emp_exists = Properties.Resources.ERR_EMPLOYEE_EXISTS;
		private string err_emp_rate = Properties.Resources.ERR_RATE_FORMAT;
		private string err_emp_hours = Properties.Resources.ERR_HOURS_FORMAT;
		private string err_emp_name = Properties.Resources.ERR_NAME_FORMAT;

		/// <summary>
		/// Takes the values inside the text boxes and calculates weekly wage
		/// </summary>
		private void btnCalculate_Click(object sender, EventArgs e)
		{
			if (employee == null)
			{
				try
				{
					ParseTextBoxes();
					CreateEmployee();

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else if (!txtName.Text.Equals(employee.Name))
			{
				try
				{
					ParseTextBoxes();
					CreateEmployee();
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

			}
			else
			{
				ParseTextBoxes();

				employee.Hours = Convert.ToDouble(txtHours.Text);
				employee.Rate = Convert.ToDouble(txtRate.Text);

				
				employee.CalculateEarnings();

				txtGross.Text = employee.GrossEarnings.ToString();
				txtTaxes.Text = employee.TaxPaid.ToString();
				txtNet.Text = employee.NetEarnings.ToString();
			}
		}

		/// <summary>
		/// Creates an Employee object using information from the text boxes
		/// and adds them to the Employee list
		/// </summary>
		private void CreateEmployee()
		{
			if (IsDuplicateEmployee(txtName.Text))
			{
				throw new Exception(err_emp_exists);
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


		/// <summary>
		/// Performs validation of the textboxes and throws appropriate exception message
		/// </summary>
		private void ParseTextBoxes()
		{
			var sName = txtName.Text;
			if (!Regex.Match(sName,@"^[a-zA-Z]*$").Success)
			{
				txtName.Focus();
				throw new Exception(err_emp_name);
			}

			var sRate = txtRate.Text;
			if (!Double.TryParse(sRate, out double rate))
			{
				txtRate.Focus();
				throw new Exception(err_emp_rate);
			}

			var sHours = txtHours.Text;
			if (!Double.TryParse(sHours, out double hours))
			{
				txtHours.Focus();
				throw new Exception(err_emp_hours);
			}

			if (rate < 15)
			{
				throw new Exception(err_emp_rate);
			}
			if (hours < 0 || hours > 168)
			{
				throw new Exception(err_emp_hours);
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
		/// Asks for confirmation before closing the application using X at top of app
		/// </summary>
		private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				var result = MessageBox.Show
					(
					app_close_msg, 
					app_close_cap, 
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

		/// <summary>
		/// Asks for confirmation before closing the application using Close button at bottom of app
		/// </summary>
		private void btnClose_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show
					(
					app_close_msg,
					app_close_cap,
					MessageBoxButtons.YesNo
					);
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
			
		}
	}
}
