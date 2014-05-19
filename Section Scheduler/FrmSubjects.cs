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
    }
}
