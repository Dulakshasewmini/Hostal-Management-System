using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hostal_Management_System
{
    internal class studentData
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\BCI  DEGREE\SEM4\VA\Hostal Management System\Hostal Management System\Hostal Management System\Database2.mdf"";Integrated Security=True";
        public int ID { get; set; }

        public string FullName { get; set; }

        public string StudentID { get; set; }

        public string JoinDate { get; set; }

        public string Payment { get; set; }

        public int RoomID { get; set; }

        public List<studentData> StudentListData()
        {
            List<studentData> listData = new List<studentData>();

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT students.id,students.full_name,students.student_id,students.date,students.payment,rooms.room_no FROM  students JOIN  rooms ON students.room_id = rooms.id; ";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        studentData sData = new studentData();
                        sData.ID = (int)reader["id"];
                        sData.FullName = reader["full_name"].ToString();
                        sData.StudentID = reader["student_id"].ToString();
                        sData.JoinDate = ((DateTime)reader["date"]).ToString("MM-dd-yyyy");
                        sData.Payment = reader["payment"].ToString();
                        sData.RoomID = (int)reader["room_no"];

                        listData.Add(sData);
                    }
                }
            }

            return listData;
        }
    }
}
