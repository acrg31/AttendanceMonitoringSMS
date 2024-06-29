namespace LUBANG_ATTENDANCE
{
    partial class FormCheckInOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckInOut));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxHas = new System.Windows.Forms.PictureBox();
            this.pictureBoxEmpty = new System.Windows.Forms.PictureBox();
            this.labelSection = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.LabelBarcodeID = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelPmAm = new System.Windows.Forms.Label();
            this.lbl_sec = new System.Windows.Forms.Label();
            this.lbl_day = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.TextBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.TextBoxBarcodeNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpty)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelDateTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 57);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(66)))), ((int)(((byte)(250)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Agency FB", 40F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(904, 57);
            this.label2.TabIndex = 33;
            this.label2.Text = "MERIDIAN EDUCATIONAL INSTITUTION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelDateTime
            // 
            this.labelDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.ForeColor = System.Drawing.Color.White;
            this.labelDateTime.Location = new System.Drawing.Point(0, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(904, 57);
            this.labelDateTime.TabIndex = 30;
            this.labelDateTime.Text = "YYYY";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 5);
            this.panel2.TabIndex = 24;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.panel3);
            this.panelContainer.Controls.Add(this.pictureBoxHas);
            this.panelContainer.Controls.Add(this.pictureBoxEmpty);
            this.panelContainer.Controls.Add(this.labelSection);
            this.panelContainer.Controls.Add(this.labelGrade);
            this.panelContainer.Controls.Add(this.labelGender);
            this.panelContainer.Controls.Add(this.labelAge);
            this.panelContainer.Controls.Add(this.label12);
            this.panelContainer.Controls.Add(this.label13);
            this.panelContainer.Controls.Add(this.label7);
            this.panelContainer.Controls.Add(this.label6);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.LabelMessage);
            this.panelContainer.Controls.Add(this.lblStudentName);
            this.panelContainer.Controls.Add(this.LabelBarcodeID);
            this.panelContainer.Location = new System.Drawing.Point(461, 77);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(437, 492);
            this.panelContainer.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(-1, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 5);
            this.panel3.TabIndex = 37;
            // 
            // pictureBoxHas
            // 
            this.pictureBoxHas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxHas.Location = new System.Drawing.Point(73, 48);
            this.pictureBoxHas.Name = "pictureBoxHas";
            this.pictureBoxHas.Size = new System.Drawing.Size(287, 234);
            this.pictureBoxHas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHas.TabIndex = 36;
            this.pictureBoxHas.TabStop = false;
            this.pictureBoxHas.Click += new System.EventHandler(this.pictureBoxHas_Click);
            // 
            // pictureBoxEmpty
            // 
            this.pictureBoxEmpty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEmpty.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEmpty.Image")));
            this.pictureBoxEmpty.Location = new System.Drawing.Point(73, 48);
            this.pictureBoxEmpty.Name = "pictureBoxEmpty";
            this.pictureBoxEmpty.Size = new System.Drawing.Size(287, 234);
            this.pictureBoxEmpty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmpty.TabIndex = 35;
            this.pictureBoxEmpty.TabStop = false;
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSection.Location = new System.Drawing.Point(159, 437);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(79, 20);
            this.labelSection.TabIndex = 34;
            this.labelSection.Text = "SECTION";
            this.labelSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrade.Location = new System.Drawing.Point(159, 411);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(72, 20);
            this.labelGrade.TabIndex = 33;
            this.labelGrade.Text = "GRADE ";
            this.labelGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(159, 385);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(79, 20);
            this.labelGender.TabIndex = 32;
            this.labelGender.Text = "GENDER";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(159, 359);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(44, 20);
            this.labelAge.TabIndex = 31;
            this.labelAge.Text = "AGE";
            this.labelAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "NAME:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 307);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "ID NUMBER:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "SECTION:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "GRADE :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "GENDER:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "AGE:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelMessage
            // 
            this.LabelMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.Location = new System.Drawing.Point(0, 0);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(435, 39);
            this.LabelMessage.TabIndex = 21;
            this.LabelMessage.Text = "LabelMessage";
            this.LabelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(159, 333);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(55, 20);
            this.lblStudentName.TabIndex = 22;
            this.lblStudentName.Text = "NAME";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelBarcodeID
            // 
            this.LabelBarcodeID.AutoSize = true;
            this.LabelBarcodeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBarcodeID.Location = new System.Drawing.Point(159, 307);
            this.LabelBarcodeID.Name = "LabelBarcodeID";
            this.LabelBarcodeID.Size = new System.Drawing.Size(100, 20);
            this.LabelBarcodeID.TabIndex = 23;
            this.LabelBarcodeID.Text = "ID NUMBER";
            this.LabelBarcodeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelBarcodeID.Click += new System.EventHandler(this.LabelBarcodeID_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.guna2Panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(427, 514);
            this.panel5.TabIndex = 35;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelPmAm);
            this.panel4.Controls.Add(this.lbl_sec);
            this.panel4.Controls.Add(this.lbl_day);
            this.panel4.Controls.Add(this.lbl_date);
            this.panel4.Controls.Add(this.lbl_time);
            this.panel4.Location = new System.Drawing.Point(5, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(389, 157);
            this.panel4.TabIndex = 35;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // labelPmAm
            // 
            this.labelPmAm.AutoSize = true;
            this.labelPmAm.Font = new System.Drawing.Font("Agency FB", 60F);
            this.labelPmAm.Location = new System.Drawing.Point(280, 0);
            this.labelPmAm.Name = "labelPmAm";
            this.labelPmAm.Size = new System.Drawing.Size(114, 96);
            this.labelPmAm.TabIndex = 36;
            this.labelPmAm.Text = "AM";
            this.labelPmAm.Click += new System.EventHandler(this.labelPmAm_Click);
            // 
            // lbl_sec
            // 
            this.lbl_sec.Font = new System.Drawing.Font("Agency FB", 25F);
            this.lbl_sec.Location = new System.Drawing.Point(211, 39);
            this.lbl_sec.Name = "lbl_sec";
            this.lbl_sec.Size = new System.Drawing.Size(53, 43);
            this.lbl_sec.TabIndex = 35;
            this.lbl_sec.Text = "SS";
            this.lbl_sec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_sec.Click += new System.EventHandler(this.lbl_sec_Click);
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.Font = new System.Drawing.Font("Agency FB", 20F);
            this.lbl_day.Location = new System.Drawing.Point(175, 119);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(54, 32);
            this.lbl_day.TabIndex = 34;
            this.lbl_day.Text = "dddd";
            // 
            // lbl_date
            // 
            this.lbl_date.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lbl_date.Font = new System.Drawing.Font("Agency FB", 20F);
            this.lbl_date.Location = new System.Drawing.Point(22, 119);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(127, 32);
            this.lbl_date.TabIndex = 32;
            this.lbl_date.Text = "MM-DD-YY";
            this.lbl_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_time
            // 
            this.lbl_time.Font = new System.Drawing.Font("Agency FB", 60F);
            this.lbl_time.Location = new System.Drawing.Point(8, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(217, 106);
            this.lbl_time.TabIndex = 33;
            this.lbl_time.Text = "00:00";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_time.Click += new System.EventHandler(this.lbl_time_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.Controls.Add(this.TextBoxBarcodeNum);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.guna2Panel1.Location = new System.Drawing.Point(7, 177);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(387, 329);
            this.guna2Panel1.TabIndex = 36;
            // 
            // TextBoxBarcodeNum
            // 
            this.TextBoxBarcodeNum.Animated = true;
            this.TextBoxBarcodeNum.AutoRoundedCorners = true;
            this.TextBoxBarcodeNum.AutoSize = true;
            this.TextBoxBarcodeNum.BackColor = System.Drawing.Color.White;
            this.TextBoxBarcodeNum.BorderRadius = 37;
            this.TextBoxBarcodeNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxBarcodeNum.DefaultText = "";
            this.TextBoxBarcodeNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxBarcodeNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxBarcodeNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxBarcodeNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxBarcodeNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxBarcodeNum.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold);
            this.TextBoxBarcodeNum.ForeColor = System.Drawing.Color.Black;
            this.TextBoxBarcodeNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxBarcodeNum.Location = new System.Drawing.Point(22, 131);
            this.TextBoxBarcodeNum.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextBoxBarcodeNum.Name = "TextBoxBarcodeNum";
            this.TextBoxBarcodeNum.PasswordChar = '\0';
            this.TextBoxBarcodeNum.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TextBoxBarcodeNum.PlaceholderText = "SCAN QRCODE";
            this.TextBoxBarcodeNum.SelectedText = "";
            this.TextBoxBarcodeNum.Size = new System.Drawing.Size(349, 76);
            this.TextBoxBarcodeNum.TabIndex = 0;
            this.TextBoxBarcodeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxBarcodeNum.TextChanged += new System.EventHandler(this.TextBoxBarcodeNum_TextChanged);
            this.TextBoxBarcodeNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBarcodeNum_KeyPress);
            // 
            // FormCheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(904, 576);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCheckInOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check in/Check out";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCheckInOut_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCheckInOut_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpty)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label labelDateTime;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label LabelBarcodeID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBoxEmpty;
        private System.Windows.Forms.PictureBox pictureBoxHas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelPmAm;
        private System.Windows.Forms.Label lbl_sec;
        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.TextBox lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxBarcodeNum;
    }
}

