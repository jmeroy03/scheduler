
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Section_Scheduler
{
    public class Course : ListViewItem
    {
        public enum AvailabilityEnum
        {
            FirstSemesterOnly = 1,
            SecondSemesterOnly = 2,
            EverySemester = 0
        };

        private Int64 id;
        private String name;
        private String description;
        private Double units;
        private Boolean isLaboratory;
        private Boolean isServiceCourse;
        private AvailabilityEnum availability;

        public Course(
            Int64 id, 
            String name, 
            String description, 
            Double units, 
            Boolean isLaboratory, 
            Boolean isServiceCourse,
            AvailabilityEnum availability)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.units = units;
            this.isLaboratory = isLaboratory;
            this.isServiceCourse = isServiceCourse;
            this.availability = availability;
            SubItems[0].Text = name.ToString();
            SubItems.Add(description.ToString());
            SubItems.Add(units.ToString());
            SubItems.Add(isLaboratory ? "Yes" : "No");
            SubItems.Add(isServiceCourse ? "Yes" : "No");
            SubItems.Add(availability == AvailabilityEnum.EverySemester ? "Every Semester" :
                        availability == AvailabilityEnum.FirstSemesterOnly ? "1st Semester Only" :
                            "2nd Semester Only");
        }

        public Int64 ID
        {
            get { return id; }
        }

        public String CourseName
        {
            get { return name; }
        }

        public String Description
        {
            get { return description; }
        }

        public Double Units
        {
            get { return units; }
        }

        public Boolean IsLaboratory
        {
            get { return isLaboratory; }
        }

        public Boolean IsServiceCourse
        {
            get { return isServiceCourse; }
        }

        public AvailabilityEnum Availability
        {
            get { return availability; }
        }

        public static Course Add(
            String name,
            String description,
            Double units,
            Boolean isLaboratory,
            Boolean isServiceCourse,
            AvailabilityEnum availability)
        {
            Int64 id;
            using (MySqlConnection con = new MySqlConnection(Program.CONNECTION_STRING))
            {
                MySqlCommand com = new MySqlCommand(
                    @"INSERT INTO COURSE(COURSE_NAME, DESCRIPTION, UNITS, LABORATORY, CLASSIFICATION, AVAILABILITY) " + 
                    "VALUES(@courseName, @description, @units, @laboratory, @classification, @availability)", con);
                com.Parameters.AddWithValue("@courseName", name);
                com.Parameters.AddWithValue("@description", description);
                com.Parameters.AddWithValue("@units", units);
                com.Parameters.AddWithValue("@laboratory", isLaboratory ? 'T' : 'F');
                com.Parameters.AddWithValue("@classification", isServiceCourse ? 'T' : 'F');
                com.Parameters.AddWithValue("@availability", 
                    availability == AvailabilityEnum.EverySemester ? 'E' : 
                        availability == AvailabilityEnum.FirstSemesterOnly ? '1' : 
                            '2');
                con.Open();
                com.ExecuteNonQuery();
                id = com.LastInsertedId;
                con.Close();
                com.Dispose();
            }
            Course course = new Course(id, name, description, units, isLaboratory, isServiceCourse, availability);            
            return course;
        }

        public static LinkedList<Course> GetList()
        {
            LinkedList<Course> courseList = new LinkedList<Course>();
            using (MySqlConnection con = new MySqlConnection(Program.CONNECTION_STRING))
            {
                MySqlDataReader reader;
                MySqlCommand com = new MySqlCommand("SELECT idcourse, course_name, description, units, laboratory, classification, availability FROM course;", con);
                con.Open();
                reader = com.ExecuteReader();                
                com.Dispose();
                while (reader.Read())
                    courseList.AddLast(new Course(
                        reader.GetInt64(0), 
                        reader.GetString(1), 
                        reader.GetString(2),
                        reader.GetDouble(3),
                        reader.GetChar(4) == 'T',
                        reader.GetChar(5) == 'T',
                        reader.GetChar(6) == 'E' ? AvailabilityEnum.EverySemester : 
                            reader.GetChar(6) == '1' ? AvailabilityEnum.FirstSemesterOnly : 
                                AvailabilityEnum.SecondSemesterOnly));
                con.Close();
            }
            return courseList;
        }

    }
}