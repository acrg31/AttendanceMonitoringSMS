namespace LUBANG_ATTENDANCE.FormReport
{
    partial class FormReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPdf = new FontAwesome.Sharp.IconButton();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnRecord = new FontAwesome.Sharp.IconButton();
            this.btnLogs = new FontAwesome.Sharp.IconButton();
            this.btnMonthly = new FontAwesome.Sharp.IconButton();
            this.btnWeekly = new FontAwesome.Sharp.IconButton();
            this.btnDaily = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 31);
            this.panel1.TabIndex = 6;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(80, 0);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(298, 31);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSearch.WordWrap = false;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnPdf);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.iconButton4);
            this.panel2.Controls.Add(this.btnRecord);
            this.panel2.Controls.Add(this.btnLogs);
            this.panel2.Controls.Add(this.btnMonthly);
            this.panel2.Controls.Add(this.btnWeekly);
            this.panel2.Controls.Add(this.btnDaily);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 518);
            this.panel2.TabIndex = 8;
            // 
            // btnPdf
            // 
            this.btnPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPdf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnPdf.IconColor = System.Drawing.Color.Crimson;
            this.btnPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPdf.IconSize = 45;
            this.btnPdf.Location = new System.Drawing.Point(0, 440);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(80, 66);
            this.btnPdf.TabIndex = 9;
            this.btnPdf.Text = "PDF";
            this.btnPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExport.IconSize = 45;
            this.btnExport.Location = new System.Drawing.Point(0, 377);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 63);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Excel";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.Location = new System.Drawing.Point(0, 325);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(80, 52);
            this.iconButton4.TabIndex = 7;
            this.iconButton4.Text = "EXPORT";
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // btnRecord
            // 
            this.btnRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnRecord.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.btnRecord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecord.IconSize = 45;
            this.btnRecord.Location = new System.Drawing.Point(0, 269);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(80, 56);
            this.btnRecord.TabIndex = 6;
            this.btnRecord.Text = "Students";
            this.btnRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogs.FlatAppearance.BorderSize = 0;
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogs.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnLogs.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.btnLogs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogs.IconSize = 45;
            this.btnLogs.Location = new System.Drawing.Point(0, 207);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(80, 62);
            this.btnLogs.TabIndex = 4;
            this.btnLogs.Text = "All Logs";
            this.btnLogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnMonthly
            // 
            this.btnMonthly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthly.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonthly.FlatAppearance.BorderSize = 0;
            this.btnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthly.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnMonthly.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(46)))), ((int)(((byte)(221)))));
            this.btnMonthly.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMonthly.IconSize = 45;
            this.btnMonthly.Location = new System.Drawing.Point(0, 137);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(80, 70);
            this.btnMonthly.TabIndex = 3;
            this.btnMonthly.Text = "Monthly";
            this.btnMonthly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMonthly.UseVisualStyleBackColor = true;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // btnWeekly
            // 
            this.btnWeekly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWeekly.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWeekly.FlatAppearance.BorderSize = 0;
            this.btnWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekly.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            this.btnWeekly.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(212)))));
            this.btnWeekly.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWeekly.IconSize = 45;
            this.btnWeekly.Location = new System.Drawing.Point(0, 67);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.Size = new System.Drawing.Size(80, 70);
            this.btnWeekly.TabIndex = 2;
            this.btnWeekly.Text = "Weekly";
            this.btnWeekly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWeekly.UseVisualStyleBackColor = true;
            this.btnWeekly.Click += new System.EventHandler(this.btnWeekly_Click);
            // 
            // btnDaily
            // 
            this.btnDaily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDaily.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDaily.FlatAppearance.BorderSize = 0;
            this.btnDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaily.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.btnDaily.IconColor = System.Drawing.Color.Crimson;
            this.btnDaily.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDaily.IconSize = 45;
            this.btnDaily.Location = new System.Drawing.Point(0, 0);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(80, 67);
            this.btnDaily.TabIndex = 1;
            this.btnDaily.Text = "Daily";
            this.btnDaily.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDaily.UseVisualStyleBackColor = true;
            this.btnDaily.Click += new System.EventHandler(this.btnDaily_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(80, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(777, 518);
            this.dataGridView1.TabIndex = 9;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 549);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnMonthly;
        private FontAwesome.Sharp.IconButton btnWeekly;
        private FontAwesome.Sharp.IconButton btnDaily;
        private FontAwesome.Sharp.IconButton btnLogs;
        private FontAwesome.Sharp.IconButton btnRecord;
        private FontAwesome.Sharp.IconButton btnExport;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnPdf;
    }
}