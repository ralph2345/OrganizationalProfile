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

namespace OrganizationProfile
{
    public partial class FrmConfirmation : Form
    {
        public FrmConfirmation()
        {
            InitializeComponent();
        }

        private void FrmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInformationClass.SetStudentNo.ToString();
            lblName.Text = StudentInformationClass.SetFullName.ToString();
            lblProgram.Text = StudentInformationClass.SetProgram.ToString();
            lblAge.Text = StudentInformationClass.SetAge.ToString();
            lblBirthday.Text = StudentInformationClass.SetBirthday.ToString();
            lblGender.Text = StudentInformationClass.SetGender.ToString();
            lblContactNo.Text = "+63"+StudentInformationClass.SetContactNo.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;    
            this.Close();
        }


    }
}
