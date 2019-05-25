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
		}

		Employee employee;
		List<Employee> employeeList = new List<Employee>();

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

				txtGross.Text = employee.GrossEarnings.ToString();
				txtTaxes.Text = employee.TaxPaid.ToString();
				txtNet.Text = employee.NetEarnings.ToString();
			}


		}


		private void ParseTextBoxes()
		{
			double rate;
			var sRate = txtRate.Text;
			if (!Double.TryParse(sRate, out rate))
			{
				txtRate.Focus();
				throw new Exception("Hourly rate is not in proper format");
			}

			double hours;
			var sHours = txtHours.Text;
			if (!Double.TryParse(sHours, out hours))
			{
				txtHours.Focus();
				throw new Exception("Hours worked is not in proper format");
			}
		}

		private void AddEmployeeToComboBox(Employee emp)
		{
			cmbEmployees.Items.Add(emp.Name);
		}

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

		private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
		{
			 employee = GetEmployee(cmbEmployees.SelectedItem.ToString());

			txtName.Text = employee.Name;
			txtRate.Text = employee.Rate.ToString();
			txtHours.Text = employee.Hours.ToString();

		}

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

		

		
		
		//Test Commit comment
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
