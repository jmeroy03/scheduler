using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section_Scheduler
{
    public partial class FrmSubjects : Form
    {
        public FrmSubjects()
        {
            InitializeComponent();
            cboAvailablity.SelectedIndex = 0;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            Course course;
            course = Course.Add(
                txtName.Text, 
                txtDescription.Text, 
                Double.Parse(txtUnits.Text), 
                chkLaboratory.Checked, 
                chkIsServiceCourse.Checked, 
                cboAvailablity.SelectedIndex == 0 ? Course.AvailabilityEnum.EverySemester : 
                    cboAvailablity.SelectedIndex == 1 ? Course.AvailabilityEnum.FirstSemesterOnly : 
                        Course.AvailabilityEnum.SecondSemesterOnly);
            lstSubjects.Items.Add(course);
        }

        private void FrmSubjects_Load(object sender, EventArgs e)
        {
            LinkedList<Course> courseList = Course.GetList();
            foreach (Course course in courseList)
                lstSubjects.Items.Add(course);
        }

        private void cboAvailablity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chkLaboratory_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chkIsServiceCourse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
