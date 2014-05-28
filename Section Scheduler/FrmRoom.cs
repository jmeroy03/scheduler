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
    public partial class FrmRoom : Form
    {
        public FrmRoom()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            Room room;
            room = Room.Add(
                txtName.Text,
                chkLaboratory.Checked,
                chkAvailability.Checked);
                lstRoom.Items.Add(room);
        }
        private void FrmRoom_Load(object sender, EventArgs e)
        {
            LinkedList<Room> roomList = Room.GetList();
            foreach (Room room in roomList)
                lstRoom.Items.Add(room);
        
        }
    }
}
