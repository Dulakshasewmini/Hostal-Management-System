using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostal_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void student_btn_Click(object sender, EventArgs e)
        {
            students1.Visible = true;
            rooms1.Visible = false;

            Students sForm = students1 as Students;

            if (sForm != null)
            {
                sForm.refreshData();
            }
        }

        private void room_button_Click(object sender, EventArgs e)
        {
            students1.Visible = false;
            rooms1.Visible = true;

            Rooms rForm = rooms1 as Rooms;

            if (rForm != null)
            {
                rForm.refreshData();
            }
        }
    }
}
