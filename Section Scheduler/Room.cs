using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Section_Scheduler
{
    public class Room : ListViewItem
    {
        private Int64 id;
        private String name;
        private Boolean ifLab;
        private Boolean isAvailable;

        public Room(
            Int64 id,
            String name,
            Boolean ifLab,
            Boolean isAvailable)
        {
            this.id = id;
            this.name = name;
            this.ifLab = ifLab;
            this.isAvailable = isAvailable;
            SubItems[0].Text = name.ToString();
            SubItems.Add(ifLab ? "Yes" : "No");
            SubItems.Add(isAvailable ? "Yes" : "No");

        }

        public Int64 ID 
        {
            get { return id; }
        }
        public String RoomName
        {
            get { return name;  }
        }
        public Boolean IfLaboratory
        {
            get { return ifLab; }
        }
		public Boolean IsAvailbable
		{
            get { return isAvailable; }
		 }

        public static Room Add(
            String name,
            Boolean iflab,
            Boolean isAvailable)
        { 
            Int64 id;
            using (MySqlConnection con = new MySqlConnection(Program.CONNECTION_STRING))
            { 
                MySqlCommand com = new MySqlCommand(
                    @"INSERT INTO ROOM(ROOM_NAME,LABORATORY, AVAILABILITY)" +
                    "VALUES (@roomName,@laboratory,@availabity)", con);
                com.Parameters.AddWithValue("@roomName", name);
                com.Parameters.AddWithValue("@laboratory", iflab ? 'T' : 'F');
                com.Parameters.AddWithValue("@available", isAvailable ? 'T': 'F' );

                con.Open();
                com.ExecuteNonQuery();
                id = com.LastInsertedId;
                con.Close();
                com.Dispose();
            }
        
        }

    }
}
