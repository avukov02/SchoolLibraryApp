using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        

        private void btnPushToTest_Click_1(object sender, EventArgs e)
        {
            var testSchool = new School();
            testSchool.Name = textName.Text;
            testSchool.City = textCity.Text;
            testSchool.State = textState.Text;
            testSchool.Zip = textZip.Text;
            testSchool.PhoneNumber = textPhone.Text;
            testSchool.Address = textAddress.Text;
            try
            {
                testSchool.TwitterAddress = textTwitter.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show(testSchool.ToString());

            var teacher = new Teacher();
        }

        private void btnTestTeacher_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher();
            var gp = teacher.ComputeGradeAverage();
            MessageBox.Show("the teacher grade average is "+gp);
        }

        private void btnTestStudent_Click(object sender, EventArgs e)
        {
            var student = new Student();
            var gp = student.ComputeGradeAverage();
            MessageBox.Show("the student grade average is " + gp);
        }
    }
}
