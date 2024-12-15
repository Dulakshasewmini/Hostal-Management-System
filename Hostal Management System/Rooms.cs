using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostal_Management_System
{
    public partial class Rooms : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\BCI  DEGREE\SEM4\VA\Hostal Management System\Hostal Management System\Hostal Management System\Database2.mdf"";Integrated Security=True";
        public Rooms()
        {
            InitializeComponent();
            displayRoomData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayRoomData();

        }

        
        public static int roomNo = 0;

        public void displayRoomData()
        {
            RoomData rData = new RoomData();
            List<RoomData> listData = rData.RoomListData();

            dataGridView1.DataSource = listData;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (roomStatus_drop.SelectedIndex == -1 || location_drp.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO rooms (room_no, room_status, date_create, location) " + " VALUES(@room_no, @room_status, @date_create, @location)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        roomNo ++;

                        cmd.Parameters.AddWithValue("@room_no", roomNo);
                        cmd.Parameters.AddWithValue("@room_status", roomStatus_drop.SelectedItem);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date_create", today);

                        cmd.Parameters.AddWithValue("@location", location_drp.SelectedItem);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    
                    connect.Close();
                }
            }

            displayRoomData();
        }

        public void clearFields()
        {
            roomStatus_drop.SelectedIndex = -1;
            location_drp.SelectedIndex = -1;
        }

        private int getID = 0;
        private int getRoomNo = 0;

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (roomStatus_drop.SelectedIndex == -1 || location_drp.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the room first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update Room No :" + getRoomNo + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string updateData = "UPDATE rooms SET room_no = @room_no, room_status = @room_status, location = @location  WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {

                            cmd.Parameters.AddWithValue("@room_status", roomStatus_drop.SelectedItem);
                            cmd.Parameters.AddWithValue("@location", location_drp.SelectedItem);
                            cmd.Parameters.AddWithValue("@room_no", getRoomNo);
                            cmd.Parameters.AddWithValue("@id", getID);


                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connect.Close();
                    }
                }

            }

            displayRoomData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                getRoomNo = Convert.ToInt32(row.Cells[1].Value);
                roomStatus_drop.SelectedItem = row.Cells[2].Value.ToString();
                location_drp.SelectedItem = row.Cells[3].Value.ToString();
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (roomStatus_drop.SelectedIndex == -1 || location_drp.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the room first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete Room No :" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM rooms WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connect.Close();
                    }
                }

            }

            displayRoomData();
        }
    }
}
