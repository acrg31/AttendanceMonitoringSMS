namespace LUBANG_ATTENDANCE.FormAdmin
{
    partial class FormStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentInfo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelQrcode = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxEmpty = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBoxHas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSection = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelPentNo = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelYearLevel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxQrcode = new System.Windows.Forms.PictureBox();
            this.qrcodeNotAvailable = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHas)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 42);
            this.panel2.TabIndex = 38;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 25;
            this.btnCancel.Location = new System.Drawing.Point(499, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(31, 42);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Student Information";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(66)))), ((int)(((byte)(250)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 10);
            this.panel1.TabIndex = 37;
            // 
            // labelQrcode
            // 
            this.labelQrcode.AutoSize = true;
            this.labelQrcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQrcode.Location = new System.Drawing.Point(305, 154);
            this.labelQrcode.Name = "labelQrcode";
            this.labelQrcode.Size = new System.Drawing.Size(41, 20);
            this.labelQrcode.TabIndex = 55;
            this.labelQrcode.Text = "LRN";
            this.labelQrcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBoxEmpty);
            this.panel3.Controls.Add(this.pictureBoxHas);
            this.panel3.Location = new System.Drawing.Point(16, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 164);
            this.panel3.TabIndex = 59;
            // 
            // pictureBoxEmpty
            // 
            this.pictureBoxEmpty.BackColor = System.Drawing.Color.White;
            this.pictureBoxEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxEmpty.ForeColor = System.Drawing.Color.Gray;
            this.pictureBoxEmpty.IconChar = FontAwesome.Sharp.IconChar.User;
            this.pictureBoxEmpty.IconColor = System.Drawing.Color.Gray;
            this.pictureBoxEmpty.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pictureBoxEmpty.IconSize = 162;
            this.pictureBoxEmpty.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEmpty.Name = "pictureBoxEmpty";
            this.pictureBoxEmpty.Size = new System.Drawing.Size(162, 162);
            this.pictureBoxEmpty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmpty.TabIndex = 62;
            this.pictureBoxEmpty.TabStop = false;
            // 
            // pictureBoxHas
            // 
            this.pictureBoxHas.BackColor = System.Drawing.Color.White;
            this.pictureBoxHas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHas.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHas.Name = "pictureBoxHas";
            this.pictureBoxHas.Size = new System.Drawing.Size(162, 162);
            this.pictureBoxHas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHas.TabIndex = 59;
            this.pictureBoxHas.TabStop = false;
            this.pictureBoxHas.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "ID Number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Age:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Date of Birth:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(201, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "Section:";
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSection.Location = new System.Drawing.Point(305, 315);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(96, 20);
            this.labelSection.TabIndex = 74;
            this.labelSection.Text = "labelSection";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.Location = new System.Drawing.Point(305, 253);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(77, 20);
            this.labelDOB.TabIndex = 71;
            this.labelDOB.Text = "labelDOB";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(305, 220);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(71, 20);
            this.labelAge.TabIndex = 70;
            this.labelAge.Text = "labelAge";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(305, 188);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(96, 20);
            this.labelGender.TabIndex = 69;
            this.labelGender.Text = "labelGender";
            // 
            // labelFullName
            // 
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelFullName.Location = new System.Drawing.Point(204, 83);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(312, 20);
            this.labelFullName.TabIndex = 68;
            this.labelFullName.Text = "labelFullName";
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPentNo
            // 
            this.labelPentNo.AutoSize = true;
            this.labelPentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPentNo.Location = new System.Drawing.Point(305, 342);
            this.labelPentNo.Name = "labelPentNo";
            this.labelPentNo.Size = new System.Drawing.Size(95, 20);
            this.labelPentNo.TabIndex = 76;
            this.labelPentNo.Text = "labelPentNo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(201, 340);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 20);
            this.label18.TabIndex = 75;
            this.label18.Text = "Contact:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(201, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 66;
            this.label8.Text = "Grade Level:";
            // 
            // labelYearLevel
            // 
            this.labelYearLevel.AutoSize = true;
            this.labelYearLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYearLevel.Location = new System.Drawing.Point(305, 283);
            this.labelYearLevel.Name = "labelYearLevel";
            this.labelYearLevel.Size = new System.Drawing.Size(113, 20);
            this.labelYearLevel.TabIndex = 73;
            this.labelYearLevel.Text = "labelYearLevel";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBoxQrcode);
            this.panel4.Controls.Add(this.qrcodeNotAvailable);
            this.panel4.Location = new System.Drawing.Point(17, 257);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(162, 123);
            this.panel4.TabIndex = 79;
            // 
            // pictureBoxQrcode
            // 
            this.pictureBoxQrcode.BackColor = System.Drawing.Color.White;
            this.pictureBoxQrcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxQrcode.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxQrcode.Name = "pictureBoxQrcode";
            this.pictureBoxQrcode.Size = new System.Drawing.Size(162, 123);
            this.pictureBoxQrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQrcode.TabIndex = 79;
            this.pictureBoxQrcode.TabStop = false;
            // 
            // qrcodeNotAvailable
            // 
            this.qrcodeNotAvailable.BackColor = System.Drawing.Color.White;
            this.qrcodeNotAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qrcodeNotAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qrcodeNotAvailable.Location = new System.Drawing.Point(0, 0);
            this.qrcodeNotAvailable.Name = "qrcodeNotAvailable";
            this.qrcodeNotAvailable.Size = new System.Drawing.Size(162, 123);
            this.qrcodeNotAvailable.TabIndex = 78;
            this.qrcodeNotAvailable.Text = "Qrcode \r\nNot Available";
            this.qrcodeNotAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(205, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(311, 5);
            this.label10.TabIndex = 80;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(530, 409);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelPentNo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.labelSection);
            this.Controls.Add(this.labelYearLevel);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelQrcode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStudentInfo";
            this.Load += new System.EventHandler(this.FormStudentInfo_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHas)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelQrcode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxHas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelPentNo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelYearLevel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label qrcodeNotAvailable;
        private System.Windows.Forms.PictureBox pictureBoxQrcode;
        private FontAwesome.Sharp.IconPictureBox pictureBoxEmpty;
        private System.Windows.Forms.Label label10;
    }
}