using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace OrganizationProfile
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Computer Engineer",
                "BS Information System",
                "BS in Accountancy",
                "BS in Hospital Management",
                "BS in Tourism Management",

            };

            for (int i = 0; i < 6; i++)
            {
                cbProgram.Items.Add(ListOfProgram[i].ToString());
            }
        }// end form load

        /////return methods 
        public long StudentNumber(string studNum)
        {
            _StudentNo = long.Parse(studNum);
            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid Contact Number");
            }
            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            else
            {
                throw new ArgumentNullException("Input string is invalid");
            }
            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid age");
            }
            return _Age;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
                StudentInformationClass.SetStudentNo = Convert.ToInt32(StudentNumber(txtStudentNo.Text));
                StudentInformationClass.SetProgram = cbProgram.Text;
                StudentInformationClass.SetGender = cbGender.Text;
                StudentInformationClass.SetContactNo = Convert.ToInt32(ContactNo(txtContactNo.Text));
                StudentInformationClass.SetAge = Age(txtAge.Text);
                StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-mm-dd");
            }

            catch (ArgumentNullException a)
            {
                MessageBox.Show("Message " + a.Message);
            }
            catch (FormatException b)
            {
                MessageBox.Show("Message " + b.Message);
            }
            catch (IndexOutOfRangeException c)
            {
                MessageBox.Show("Message " + c.Message);
            }
            catch (OverflowException d)
            {
                MessageBox.Show("Message " + d.Message);
            }
            finally
            {
                MessageBox.Show("Invalid input format, Try another registration.");
            }

            FrmConfirmation frmConfirmation = new FrmConfirmation();

            if (frmConfirmation.ShowDialog() == DialogResult.OK)
            {
                txtAge.Text = "";
                txtContactNo.Text = "";
                txtFirstName.Text = "";
                txtMiddleInitial.Text = "";
                txtLastName.Text = "";
                txtStudentNo.Text = "";
                cbProgram.Text = "";
                cbGender.Text = "";
                datePickerBirthday.Text = string.Empty;

            }
        }
    }
}