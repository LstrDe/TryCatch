using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch
{
    public partial class frmConformation : Form
    {
        public frmConformation()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmConformation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInformationClass.SetStudentNo.ToString();
            lblName.Text = StudentInformationClass.SetFullname;
            lblProgram.Text = StudentInformationClass.SetProgram;
            lblGender.Text = StudentInformationClass.SetGender;
            lblBirthday.Text = StudentInformationClass.SetBirthday;
            lblContactNo.Text = "+63" + StudentInformationClass.SetContactNo.ToString();
            lblAge.Text = StudentInformationClass.SetAge.ToString();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registration Successfully!", "Message");
        }
    }
}
