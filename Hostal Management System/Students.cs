using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Hostal_Management_System
{
    public partial class Students : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\BCI  DEGREE\SEM4\VA\Hostal Management System\Hostal Management System\Hostal Management System\Database2.mdf"";Integrated Security=True";

        public Students()
        {
            InitializeComponent();
            displayRoomList();
            displayStudentData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayRoomList();
            displayStudentData();

        }

        public void displayStudentData()
        {
            studentData sData = new studentData();
            List<studentData> listData = sData.StudentListData();

            dataGridView1.DataSource = listData;
        }

        public void displayRoomList()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT room_no FROM rooms WHERE room_status = @room_status";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@room_status", "Available");

                    room_drop.Items.Clear();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        room_drop.Items.Add(reader["room_no"].ToString());
                    }
                }

                connect.Close();
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (payment_drop.SelectedIndex == -1 || name_txt.Text == "" || studentID_txt.Text == "" || room_drop.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO students (full_name, student_id, date, payment, date_create, room_id) " + " VALUES(@full_name, @student_id, @date, @payment, @date_create, @room_id)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@full_name", name_txt.Text);
                        cmd.Parameters.AddWithValue("@student_id", studentID_txt.Text);
                        cmd.Parameters.AddWithValue("@date", date_pick.Value);
                        cmd.Parameters.AddWithValue("@payment", payment_drop.SelectedItem);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date_create", today);

                        cmd.Parameters.AddWithValue("@room_no", room_drop.SelectedItem);

                        cmd.ExecuteNonQuery();
                      

                        MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    string updateData = "UPDATE rooms SET room_status = @room_status WHERE room_no = @room_no";

                    using (SqlCommand cmd = new SqlCommand(updateData, connect))
                    {
                        cmd.Parameters.AddWithValue("@room_status", "Fill");
                        cmd.Parameters.AddWithValue("@room_no", room_drop.SelectedItem);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Room updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                  

                    connect.Close();
                }
            }

            displayStudentData();
        }

        public void clearFields()
        {
            name_txt.Text = "";
            payment_drop.SelectedIndex = -1;
            room_drop.SelectedIndex = -1;
            studentID_txt.Text = "";
        }

        private int getID = 0;

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (payment_drop.SelectedIndex == -1 || name_txt.Text == "" || studentID_txt.Text == "" || room_drop.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the student first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update ID:" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string updateData = "UPDATE students SET full_name = @full_name, student_id = @student_id, date = @date, payment = @payment, room_no = @room_no  WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@full_name", name_txt.Text);
                            cmd.Parameters.AddWithValue("@student_id", studentID_txt.Text);
                            cmd.Parameters.AddWithValue("@date", date_pick.Value);
                            cmd.Parameters.AddWithValue("@payment", payment_drop.SelectedItem);
                            cmd.Parameters.AddWithValue("@room_no", room_drop.SelectedItem);
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            

                            MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        string updateData1 = "UPDATE rooms SET room_status = @room_status WHERE room_no = @room_no";

                        using (SqlCommand cmd = new SqlCommand(updateData1, connect))
                        {
                            cmd.Parameters.AddWithValue("@room_status", "Fill");
                            cmd.Parameters.AddWithValue("@room_no", room_drop.SelectedItem);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Room updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connect.Close();
                    }
                }

            }

            displayStudentData();
        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                name_txt.Text = row.Cells[1].Value.ToString();
                studentID_txt.Text = row.Cells[2].Value.ToString();
                date_pick.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                payment_drop.SelectedItem = row.Cells[4].Value.ToString();
                room_drop.SelectedItem = row.Cells[5].Value.ToString();

            }

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (payment_drop.SelectedIndex == -1 || name_txt.Text == "" || studentID_txt.Text == "" || room_drop.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the student first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID:" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM students WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            

                            MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }


                        string updateData1 = "UPDATE rooms SET room_status = @room_status WHERE room_no = @room_no";

                        using (SqlCommand cmd = new SqlCommand(updateData1, connect))
                        {
                            cmd.Parameters.AddWithValue("@room_status", "Available");
                            cmd.Parameters.AddWithValue("@room_no", room_drop.SelectedItem);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Room updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connect.Close();
                    }
                }

            }

            displayStudentData();
        }
    }
}
