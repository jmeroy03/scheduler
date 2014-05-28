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
        private String roomname;
        private Boolean ifLab;
        private Boolean isAvailable;

        public Room(
            Int64 id,
            String roomname,
            Boolean ifLab,
            Boolean isAvailable)
        {
            this.id = id;
            this.roomname = roomname;
            this.ifLab = ifLab;
            this.isAvailable = isAvailable;
            SubItems[0].Text = roomname.ToString();
            SubItems.Add(ifLab ? "Yes" : "No");
            SubItems.Add(isAvailable ? "Yes" : "No");

        }

        public Int64 ID 
        {
            get { return id; }
        }
        public String RoomName
        {
            get { return roomname;  }
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
            String roomname,
            Boolean iflab,
            Boolean isAvailable)
        { 
            Int64 id;
            using (MySqlConnection con = new MySqlConnection(Program.CONNECTION_STRING))
            { 
                MySqlCommand com = new MySqlCommand(
                    @"INSERT INTO ROOM(ROOM_NAME,LABORATORY, AVAILABILITY)" +
                    "VALUES (@roomName,@laboratory,@availability)", con);
                com.Parameters.AddWithValue("@roomName", roomname);
                com.Parameters.AddWithValue("@laboratory", iflab ? 'T' : 'F');
                com.Parameters.AddWithValue("@availability", isAvailable ? 'T': 'F' );

                con.Open();
                com.ExecuteNonQuery();
                id = com.LastInsertedId;
                con.Close();
                com.Dispose();
            }
            Room room = new Room(id, roomname, iflab, isAvailable);
            return room;

        }
        public static LinkedList<Room> GetList() 
        { 
            LinkedList <Room> roomList = new LinkedList<Room>();
			using (MySqlConnection con = new MySqlConnection(Program.CONNECTION_STRING))
			{
				MySqlDataReader reader;
				MySqlCommand com = new MySqlCommand("SELECT idroom, room_name, laboratory, availability FROM room",con);
				con.Open();
				reader = com.ExecuteReader();
				com.Dispose();
				while (reader.Read())
					roomList.AddLast(new Room(
						reader.GetInt64(0),
						reader.GetString(1),
						reader.GetChar(2) == 'T',
						reader.GetChar(3) == 'T'));
						
				con.Close();
			}
			return roomList;
        }


    }
}
