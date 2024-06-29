namespace LUBANG_ATTENDANCE.FormAdmin
{
    partial class FormDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelLighT = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelRed = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelPmAm = new System.Windows.Forms.Label();
            this.lbl_sec = new System.Windows.Forms.Label();
            this.lbl_day = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.TextBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnAddHoliday = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButtonUsers = new FontAwesome.Sharp.IconButton();
            this.iconButtonTotalInOut = new FontAwesome.Sharp.IconButton();
            this.iconButtonTodayInOut = new FontAwesome.Sharp.IconButton();
            this.iconButtonStudent = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panelGreen.SuspendLayout();
            this.panelLighT.SuspendLayout();
            this.panelBlue.SuspendLayout();
            this.panelRed.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panelGreen);
            this.panel2.Controls.Add(this.panelLighT);
            this.panel2.Controls.Add(this.panelBlue);
            this.panel2.Controls.Add(this.panelRed);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1401, 169);
            this.panel2.TabIndex = 2;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.panelGreen.Controls.Add(this.iconButtonUsers);
            this.panelGreen.Controls.Add(this.label5);
            this.panelGreen.Location = new System.Drawing.Point(1051, 4);
            this.panelGreen.Margin = new System.Windows.Forms.Padding(4);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(337, 156);
            this.panelGreen.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 43);
            this.label5.TabIndex = 2;
            this.label5.Text = "TODAY PRESENT";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelLighT
            // 
            this.panelLighT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.panelLighT.Controls.Add(this.iconButtonTotalInOut);
            this.panelLighT.Controls.Add(this.label4);
            this.panelLighT.Location = new System.Drawing.Point(697, 4);
            this.panelLighT.Margin = new System.Windows.Forms.Padding(4);
            this.panelLighT.Name = "panelLighT";
            this.panelLighT.Size = new System.Drawing.Size(337, 156);
            this.panelLighT.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 43);
            this.label4.TabIndex = 2;
            this.label4.Text = "TODAY LATE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.panelBlue.Controls.Add(this.iconButtonTodayInOut);
            this.panelBlue.Controls.Add(this.label3);
            this.panelBlue.Location = new System.Drawing.Point(352, 5);
            this.panelBlue.Margin = new System.Windows.Forms.Padding(4);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(331, 156);
            this.panelBlue.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "IN/OUT TODAY";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.panelRed.Controls.Add(this.iconButtonStudent);
            this.panelRed.Controls.Add(this.label2);
            this.panelRed.Location = new System.Drawing.Point(16, 5);
            this.panelRed.Margin = new System.Windows.Forms.Padding(4);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(321, 156);
            this.panelRed.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "STUDENTS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panelRed;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panelBlue;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panelLighT;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panelGreen;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelPmAm);
            this.panel4.Controls.Add(this.lbl_sec);
            this.panel4.Controls.Add(this.lbl_day);
            this.panel4.Controls.Add(this.lbl_date);
            this.panel4.Controls.Add(this.lbl_time);
            this.panel4.Location = new System.Drawing.Point(929, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(472, 161);
            this.panel4.TabIndex = 36;
            // 
            // labelPmAm
            // 
            this.labelPmAm.AutoSize = true;
            this.labelPmAm.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPmAm.Location = new System.Drawing.Point(315, 13);
            this.labelPmAm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPmAm.Name = "labelPmAm";
            this.labelPmAm.Size = new System.Drawing.Size(114, 96);
            this.labelPmAm.TabIndex = 36;
            this.labelPmAm.Text = "AM";
            // 
            // lbl_sec
            // 
            this.lbl_sec.Font = new System.Drawing.Font("Agency FB", 25F);
            this.lbl_sec.Location = new System.Drawing.Point(246, 49);
            this.lbl_sec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sec.Name = "lbl_sec";
            this.lbl_sec.Size = new System.Drawing.Size(71, 53);
            this.lbl_sec.TabIndex = 35;
            this.lbl_sec.Text = "SS";
            this.lbl_sec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.Font = new System.Drawing.Font("Agency FB", 20F);
            this.lbl_day.Location = new System.Drawing.Point(233, 113);
            this.lbl_day.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(66, 42);
            this.lbl_day.TabIndex = 34;
            this.lbl_day.Text = "dddd";
            this.lbl_day.Click += new System.EventHandler(this.lbl_day_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lbl_date.Font = new System.Drawing.Font("Agency FB", 20F);
            this.lbl_date.Location = new System.Drawing.Point(56, 113);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(169, 40);
            this.lbl_date.TabIndex = 32;
            this.lbl_date.Text = "MM-DD-YY";
            this.lbl_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_time
            // 
            this.lbl_time.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(4, -1);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(260, 131);
            this.lbl_time.TabIndex = 33;
            this.lbl_time.Text = "00:00";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_time.Click += new System.EventHandler(this.lbl_time_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(64, 261);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 33;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            // 
            // btnAddHoliday
            // 
            this.btnAddHoliday.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddHoliday.IconColor = System.Drawing.Color.Black;
            this.btnAddHoliday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddHoliday.Location = new System.Drawing.Point(127, 533);
            this.btnAddHoliday.Name = "btnAddHoliday";
            this.btnAddHoliday.Size = new System.Drawing.Size(116, 61);
            this.btnAddHoliday.TabIndex = 34;
            this.btnAddHoliday.Text = "Add No Classes";
            this.btnAddHoliday.UseVisualStyleBackColor = true;
            this.btnAddHoliday.Click += new System.EventHandler(this.btnAddHoliday_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.SystemColors.Info;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1119, 583);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(270, 82);
            this.iconButton1.TabIndex = 32;
            this.iconButton1.Text = "ABOUT US?";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 169);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1401, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // iconButtonUsers
            // 
            this.iconButtonUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButtonUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButtonUsers.FlatAppearance.BorderSize = 0;
            this.iconButtonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.iconButtonUsers.ForeColor = System.Drawing.Color.White;
            this.iconButtonUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButtonUsers.IconColor = System.Drawing.Color.White;
            this.iconButtonUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUsers.IconSize = 80;
            this.iconButtonUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonUsers.Location = new System.Drawing.Point(0, 0);
            this.iconButtonUsers.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonUsers.Name = "iconButtonUsers";
            this.iconButtonUsers.Size = new System.Drawing.Size(337, 113);
            this.iconButtonUsers.TabIndex = 3;
            this.iconButtonUsers.Text = "00";
            this.iconButtonUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonUsers.UseVisualStyleBackColor = false;
            // 
            // iconButtonTotalInOut
            // 
            this.iconButtonTotalInOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButtonTotalInOut.FlatAppearance.BorderSize = 0;
            this.iconButtonTotalInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTotalInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.iconButtonTotalInOut.ForeColor = System.Drawing.Color.White;
            this.iconButtonTotalInOut.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButtonTotalInOut.IconColor = System.Drawing.Color.White;
            this.iconButtonTotalInOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTotalInOut.IconSize = 80;
            this.iconButtonTotalInOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonTotalInOut.Location = new System.Drawing.Point(0, 0);
            this.iconButtonTotalInOut.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonTotalInOut.Name = "iconButtonTotalInOut";
            this.iconButtonTotalInOut.Size = new System.Drawing.Size(337, 113);
            this.iconButtonTotalInOut.TabIndex = 3;
            this.iconButtonTotalInOut.Text = "00";
            this.iconButtonTotalInOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTotalInOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonTotalInOut.UseVisualStyleBackColor = true;
            // 
            // iconButtonTodayInOut
            // 
            this.iconButtonTodayInOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButtonTodayInOut.FlatAppearance.BorderSize = 0;
            this.iconButtonTodayInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTodayInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.iconButtonTodayInOut.ForeColor = System.Drawing.Color.White;
            this.iconButtonTodayInOut.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconButtonTodayInOut.IconColor = System.Drawing.Color.White;
            this.iconButtonTodayInOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTodayInOut.IconSize = 80;
            this.iconButtonTodayInOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonTodayInOut.Location = new System.Drawing.Point(0, 0);
            this.iconButtonTodayInOut.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonTodayInOut.Name = "iconButtonTodayInOut";
            this.iconButtonTodayInOut.Size = new System.Drawing.Size(331, 113);
            this.iconButtonTodayInOut.TabIndex = 4;
            this.iconButtonTodayInOut.Text = "00";
            this.iconButtonTodayInOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTodayInOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonTodayInOut.UseVisualStyleBackColor = true;
            this.iconButtonTodayInOut.Click += new System.EventHandler(this.iconButtonTodayInOut_Click);
            // 
            // iconButtonStudent
            // 
            this.iconButtonStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.iconButtonStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButtonStudent.FlatAppearance.BorderSize = 0;
            this.iconButtonStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.iconButtonStudent.ForeColor = System.Drawing.Color.White;
            this.iconButtonStudent.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButtonStudent.IconColor = System.Drawing.Color.White;
            this.iconButtonStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonStudent.IconSize = 80;
            this.iconButtonStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonStudent.Location = new System.Drawing.Point(0, 0);
            this.iconButtonStudent.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonStudent.Name = "iconButtonStudent";
            this.iconButtonStudent.Size = new System.Drawing.Size(321, 113);
            this.iconButtonStudent.TabIndex = 2;
            this.iconButtonStudent.Text = "00";
            this.iconButtonStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonStudent.UseVisualStyleBackColor = false;
            this.iconButtonStudent.Click += new System.EventHandler(this.iconButtonStudent_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 677);
            this.Controls.Add(this.btnAddHoliday);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panelGreen.ResumeLayout(false);
            this.panelLighT.ResumeLayout(false);
            this.panelBlue.ResumeLayout(false);
            this.panelRed.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelLighT;
        private System.Windows.Forms.Panel panelBlue;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButtonUsers;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButtonTotalInOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButtonTodayInOut;
        private FontAwesome.Sharp.IconButton iconButtonStudent;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelPmAm;
        private System.Windows.Forms.Label lbl_sec;
        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.TextBox lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private FontAwesome.Sharp.IconButton btnAddHoliday;
    }
}