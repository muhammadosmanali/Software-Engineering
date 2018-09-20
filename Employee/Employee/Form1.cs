using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor of Form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On page load, it forms the object of the employee i.e UserControl and bring it to front.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            AddEmployee n = new AddEmployee();
            this.Controls.Add(n);
            n.BringToFront();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// it forms the object of the attendencess i.e UserControl and bring it to front.
        /// </summary>
        private void llblAttendence_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Attendencess att = new Attendencess();
            this.Controls.Add(att);
            att.BringToFront();
        }

        /// <summary>
        /// it forms the object of the ShortAttEmployee i.e UserControl and bring it to front.
        /// </summary>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShortAttEmployee sae = new ShortAttEmployee();
            this.Controls.Add(sae);
            sae.BringToFront();
        }

        /// <summary>
        /// it forms the object of the CheckAttenOfEmployee i.e UserControl and bring it to front.
        /// </summary>
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckAttenOfEmployee cae = new CheckAttenOfEmployee();
            this.Controls.Add(cae);
            cae.BringToFront();
        }

        /// <summary>
        /// It close the application form.
        /// </summary>
        private void llblClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// it forms the object of the AddEmployee i.e UserControl and bring it to front.
        /// </summary>
        private void llblEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEmployee n = new AddEmployee();
            this.Controls.Add(n);
            n.BringToFront();
        }

        /// <summary>
        /// it forms the object of the TotalServices i.e UserControl and bring it to front.
        /// </summary>
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TotalServices ts = new TotalServices();
            this.Controls.Add(ts);
            ts.BringToFront();
        }
    }
}
