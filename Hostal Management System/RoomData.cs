using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostal_Management_System
{
    internal class RoomData
    {

        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\BCI  DEGREE\SEM4\VA\Hostal Management System\Hostal Management System\Hostal Management System\Database2.mdf"";Integrated Security=True";

        public int ID { get; set; }
        public int RoomNo { get; set; }

        public string Status { get; set; }

        public string Location { get; set; }

        public List<RoomData> RoomListData()
        {
            List<RoomData> listData = new List<RoomData>();

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM rooms";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        RoomData rData = new RoomData();
                        rData.ID = (int)reader["id"];
                        rData.RoomNo = (int)reader["room_no"];
                        rData.Status = reader["room_status"].ToString();
                        rData.Location = reader["location"].ToString();
                        

                        listData.Add(rData);
                    }
                }
            }

            return listData;
        }
    }
}
