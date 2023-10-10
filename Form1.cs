using System.Text.RegularExpressions;

namespace TryCatch
{
    public partial class Form1 : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListofProgram = new string[]
           {

                "BS Information Technology",
                "BS Computer Science",
                "BS Information System",
                "BS in Information Accountancy",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management",
                "BS in Multimedia Arts"

           };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListofProgram[i].ToString());
            }
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");

        }
        public long StudentNumber(string stdNum)
        {
            try
            {
                _StudentNo = long.Parse(stdNum);
            }
            catch (FormatException a)
            {
                MessageBox.Show("Invalid input", "ERROR!");
            }
            return _StudentNo;
        }
        public long ContactNo(string Contact)
        {
            try
            {
                if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
                {
                    _ContactNo = long.Parse(Contact);
                }
                else
                {
                    throw new FormatException();
                }
            }

            catch (FormatException b)
            {
                MessageBox.Show("Invalid input", "ERROR!");
            }
            return _ContactNo;
        }
        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            try
            {
                if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
                {
                    _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
                }
                else
                {
                    throw new ArgumentNullException();
                    throw new FormatException();
                }
            }
            catch (ArgumentException a)
            {
                MessageBox.Show("Please input your name.", "ERROR!");
            }
            catch (FormatException a)
            {
                MessageBox.Show("Invalid data input.", "ERROR!");

            }
            return _FullName;
        }
        public int Age(string age)
        {
            try
            {
                if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
                {
                    _Age = Int32.Parse(age);
                }
                else
                {
                    throw new ArgumentNullException();
                    throw new FormatException();
                }
            }
            catch (ArgumentNullException b)
            {
                MessageBox.Show("Please insert your age.", "ERROR!");
            }
            catch (FormatException b)
            {
                MessageBox.Show("Invalid data input.", "ERROR!");

            }
            return _Age;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            StudentInformationClass.SetFullname = FullName(txtLastName.Text, txtFirstname.Text, txtMiddleInitial.Text);
            StudentInformationClass.SetStudentNo = Convert.ToInt64(StudentNumber(txtStudentNo.Text));
            StudentInformationClass.SetProgram = cbPrograms.Text;
            StudentInformationClass.SetGender = cbGender.Text;
            StudentInformationClass.SetContactNo = Convert.ToInt64(ContactNo(txtContactNo.Text));
            StudentInformationClass.SetAge = Age(txtAge.Text);
            StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
            frmConformation frm = new frmConformation();
            frm.ShowDialog();
        }
    }
}