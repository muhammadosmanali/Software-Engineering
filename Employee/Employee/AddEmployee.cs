using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Employee
{
    public partial class AddEmployee : UserControl
    {
        //Initialize n to 0 for employee Id
        int n = 0;
        /// <summary>
        /// Constructor
        /// </summary>
        public AddEmployee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This Function add employee to the data grid view
        /// </summary>
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            //It tries the following procedure.
            try
            {
                //This statement check that text boxes should not be empty
                if (txtName.Text != "" && txtId.Text != "" && txtCnic.Text != "" && txtSalary.Text != null && txtEmail.Text != "" && txtAddress.Text != "")
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
                                n += 1;
                                //Form object of employee
                                //set employee data members to text boxes text
                                //Add them to employee list
                                //And show them to the Data Grid View
                                Employee employee = new Employee();
                                txtId.Text = "Emp-" + (n).ToString();
                                employee.Name = txtName.Text;
                                employee.EmployeeId = txtId.Text;
                                employee.CNIC = txtCnic.Text;
                                employee.AppointmentDate = dtpAppDate.Value;
                                employee.MonthlySalary = Convert.ToDouble(txtSalary.Text);
                                employee.EmailId = txtEmail.Text;
                                employee.MailingAddress = txtAddress.Text;

                                Payroll.getInstance.addEmployee(employee);

                                BindingSource source = new BindingSource();
                                source.DataSource = Payroll.getInstance.ListOfEmployees();
                                dgvEmployee.DataSource = source;
                                //clear();
                                lblmessege.Text = "";
                            }
                            else
                            {
                                lblmessege.Text = "Invalid Email";
                            }
                        }
                        else
                        {
                            lblmessege.Text = "Invalid CNIC";
                        }
                    }
                    else
                    {
                        lblmessege.Text = "Invalid Name";
                    }
                }
                else
                {
                    lblmessege.Text = "Information is Missing";
                }
            }
            catch
            {
                lblmessege.Text = "Please type salary in numbers";
            }    
        }

        /// <summary>
        /// This function clears all the textboxes.
        /// </summary>
        public void clear()
        {
            txtAddress.Text = txtCnic.Text = txtEmail.Text = txtName.Text = "";
            txtSalary = null;
        }

        /// <summary>
        /// On page load it shows the list of employees in datagridview
        /// </summary>
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            txtId.Text = "Emp-" + (n).ToString();
            BindingSource source = new BindingSource();
            source.DataSource = Payroll.getInstance.ListOfEmployees();
            dgvEmployee.DataSource = source;
        }

        /// <summary>
        /// Check the format of employee Id
        /// </summary>
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if(txtId.Text.All(c => c.Equals('E') || c.Equals('m') || c.Equals('p') || c.Equals('-') || char.IsDigit(c)))
            {
                lblmessege.Text = "";
            }
            else
            {
                lblmessege.Text = "Please type in format: Emp-1";
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
