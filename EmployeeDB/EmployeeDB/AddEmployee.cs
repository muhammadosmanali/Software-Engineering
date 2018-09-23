using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeDB
{
    public partial class AddEmployee : UserControl
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// It Add Employee to the DataBase And do validations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            txtId.Text = "Emp-" + countRows();
            //This statement check that text boxes should not be empty
            if (txtName.Text != "" && txtId.Text != "" && txtCnic.Text != "" && txtSalary.Text != null && txtEmail.Text != "" && txtMailingAddress.Text != "")
            {
                //This statement check the name is valid or not
                if (Regex.IsMatch(txtName.Text, "^[a-zA-Z ]+$"))
                {
                    //This statement check the cnic is of 13 numbers and contain only digits
                    if (txtCnic.Text.Length == 13 && txtCnic.Text.All(c => char.IsDigit(c)))
                    {
                        //This statement validate the email.
                        if (Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                        {
                            //Check employee id is already present in database or not
                            if (checkEmpIdInDB() > 0)
                            {
                                lblEmpIdMessege.Text = "Employee Id is already present";
                            }
                            //Check employee cnic is already present in database or not
                            else if (checkCnicInDB() > 0)
                            {
                                lblCnicMessege.Text = "CNIC is already present";
                                lblEmpIdMessege.Text = "";
                            }
                            //Check employee email is already present in database or not
                            else if (checkEmailInDB() > 0)
                            {
                                lblEmailMessege.Text = "Email is alredy present";
                                lblCnicMessege.Text = "";
                            }
                            //Add Data to the Database
                            else
                            {
                                addEmployee();
                                dgvEmployee.DataSource = Payroll.getInstance.ListOfEmployee();
                                lblEmployeeAdded.Text = "Total Employees Added: " + DataBaseConnection.getInstance().CountRows("EmployeeData");
                            }
                        }
                        else
                        {
                            lblEmailMessege.Text = "Invalid Email";
                            lblCnicMessege.Text = "";
                        }
                    }
                    else
                    {
                        lblCnicMessege.Text = "Invalid CNIC";
                        lblNameMessege.Text = "";
                    }
                }
                else
                {
                    lblNameMessege.Text = "Invalid Name";
                    lblMessege.Text = "";
                }
            }
            else
            {
                lblMessege.Text = "Information is Missing";
            }
        }

        /// <summary>
        /// clear all the label's text
        /// </summary>          
        private void clearLabel()
        {
            lblNameMessege.Text = lblEmpIdMessege.Text = lblCnicMessege.Text = lblSalaryMessege.Text = lblEmailMessege.Text = lblAddressMessege.Text = "";
            
        }

        /// <summary>
        /// This function add the data to the database.
        /// </summary>
        private void addEmployee()
        {
            try
            {
                Employee employee = new Employee();
                employee.Name = txtName.Text;
                employee.EmployeeId = txtId.Text;
                employee.CNIC = txtCnic.Text;
                employee.AppointmentDate = dtpAppointmentDate.Value;
                employee.MonthlySalary = Convert.ToDouble(txtSalary.Text);
                employee.EmailId = txtEmail.Text;
                employee.MailingAddress = txtMailingAddress.Text;
                Payroll.getInstance.addEmployee(employee);
                clearLabel();
                MessageBox.Show("Employee has been Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         
        /// <summary>
        /// Check that email is already present in database.
        /// </summary>
        /// <returns>return the integer value if greater than 1 it means email is already present</returns>
        private int checkEmailInDB()
        {
            int checkEmail = DataBaseConnection.getInstance().alreadyPresentInDB(txtEmail.Text, "EmployeeData", "Email");
            return checkEmail;
        }

        /// <summary>
        /// Check that Employee id is already present in database.
        /// </summary>
        /// <returns>return the integer value if greater than 1 it means Employeeid is already present</returns>
        private int checkEmpIdInDB()
        {
            int checkEmpId = DataBaseConnection.getInstance().alreadyPresentInDB(txtId.Text, "EmployeeData", "EmployeeId");
            return checkEmpId;
        }

        /// <summary>
        /// Check that cnic is already present in database.
        /// </summary>
        /// <returns>return the integer value if greater than 1 it means cnic is already present</returns>
        private int checkCnicInDB()
        {
            int checkCnic = DataBaseConnection.getInstance().alreadyPresentInDB(txtCnic.Text, "EmployeeData", "Cnic");
            return checkCnic;
        }

        /// <summary>
        /// On load it shows the data in datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = Payroll.getInstance.ListOfEmployee();
            lblEmployeeAdded.Text = "Total Employees Added: " + DataBaseConnection.getInstance().CountRows("EmployeeData");
            txtId.Text = "Emp-" + countRows();
        }

        /// <summary>
        /// Count the number of rows in datatable of database
        /// </summary>
        /// <returns></returns>
        private int countRows()
        {
            int count = DataBaseConnection.getInstance().CountRows("EmployeeData") + 1;
            return count;
        }

        /// <summary>
        /// Validate the employee id text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.All(c => c.Equals('E') || c.Equals('m') || c.Equals('p') || c.Equals('-') || char.IsDigit(c)))
            {
                lblEmpIdMessege.Text = "";
            }
            else
            {
                lblEmpIdMessege.Text = "Please type in format: Emp-1";
            }
        }
    }
}
