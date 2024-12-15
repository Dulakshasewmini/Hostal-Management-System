namespace Hostal_Management_System
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.room_button = new System.Windows.Forms.Button();
            this.student_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rooms1 = new Hostal_Management_System.Rooms();
            this.students1 = new Hostal_Management_System.Students();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.room_button);
            this.panel1.Controls.Add(this.student_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 488);
            this.panel1.TabIndex = 0;
            // 
            // room_button
            // 
            this.room_button.BackColor = System.Drawing.Color.LightGreen;
            this.room_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.room_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.room_button.Location = new System.Drawing.Point(30, 393);
            this.room_button.Name = "room_button";
            this.room_button.Size = new System.Drawing.Size(234, 56);
            this.room_button.TabIndex = 9;
            this.room_button.Text = "Rooms";
            this.room_button.UseVisualStyleBackColor = false;
            this.room_button.Click += new System.EventHandler(this.room_button_Click);
            // 
            // student_btn
            // 
            this.student_btn.BackColor = System.Drawing.Color.LightGreen;
            this.student_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.student_btn.Location = new System.Drawing.Point(30, 288);
            this.student_btn.Name = "student_btn";
            this.student_btn.Size = new System.Drawing.Size(234, 56);
            this.student_btn.TabIndex = 8;
            this.student_btn.Text = "Students";
            this.student_btn.UseVisualStyleBackColor = false;
            this.student_btn.Click += new System.EventHandler(this.student_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 55);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(83, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hostal Management";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.DarkGreen;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(1010, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(27, 25);
            this.exit.TabIndex = 8;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rooms1);
            this.panel3.Controls.Add(this.students1);
            this.panel3.Location = new System.Drawing.Point(295, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(743, 485);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hostal_Management_System.Properties.Resources.Country_House11;
            this.pictureBox2.Location = new System.Drawing.Point(6, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hostal_Management_System.Properties.Resources.Country_House1;
            this.pictureBox1.Location = new System.Drawing.Point(87, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rooms1
            // 
            this.rooms1.Location = new System.Drawing.Point(0, 0);
            this.rooms1.Name = "rooms1";
            this.rooms1.Size = new System.Drawing.Size(743, 485);
            this.rooms1.TabIndex = 1;
            // 
            // students1
            // 
            this.students1.Location = new System.Drawing.Point(0, 0);
            this.students1.Name = "students1";
            this.students1.Size = new System.Drawing.Size(743, 485);
            this.students1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 541);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button room_button;
        private System.Windows.Forms.Button student_btn;
        private Students students1;
        private Rooms rooms1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}