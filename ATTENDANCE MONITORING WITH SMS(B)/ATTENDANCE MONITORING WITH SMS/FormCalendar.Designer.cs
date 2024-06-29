using System;

namespace LUBANG_ATTENDANCE
{
    partial class FormCalendar
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
            this.add_button_holiday = new System.Windows.Forms.Button();
            this.DatePK = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tb_Holiday = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.add_button_holiday);
            this.panel1.Controls.Add(this.DatePK);
            this.panel1.Controls.Add(this.tb_Holiday);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 87);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "";
            // 
            // add_button_holiday
            // 
            this.add_button_holiday.Location = new System.Drawing.Point(1157, 43);
            this.add_button_holiday.Name = "add_button_holiday";
            this.add_button_holiday.Size = new System.Drawing.Size(100, 34);
            this.add_button_holiday.TabIndex = 4;
            this.add_button_holiday.Text = "Add";
            this.add_button_holiday.UseVisualStyleBackColor = true;
            this.add_button_holiday.Click += new System.EventHandler(this.add_button_holiday_Click);
            // 
            // DatePK
            // 
            this.DatePK.Checked = true;
            this.DatePK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatePK.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatePK.Location = new System.Drawing.Point(781, 43);
            this.DatePK.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DatePK.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DatePK.Name = "DatePK";
            this.DatePK.Size = new System.Drawing.Size(200, 36);
            this.DatePK.TabIndex = 3;
            this.DatePK.Tag = "sdsd";
            this.DatePK.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.DatePK.Value = new System.DateTime(2023, 12, 22, 17, 47, 27, 605);
            this.DatePK.ValueChanged += new System.EventHandler(this.DatePK_ValueChanged);
            // 
            // tb_Holiday
            // 
            this.tb_Holiday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Holiday.Location = new System.Drawing.Point(1004, 43);
            this.tb_Holiday.Name = "tb_Holiday";
            this.tb_Holiday.Size = new System.Drawing.Size(130, 34);
            this.tb_Holiday.TabIndex = 1;
            this.tb_Holiday.TextChanged += new System.EventHandler(this.tb_Holiday_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Calendar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1317, 585);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(738, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(519, 398);
            this.dataGridView1.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(314, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(381, 398);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // FormCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 668);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCalendar";
            this.Load += new System.EventHandler(this.FormCalendar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DatePK;
        private System.Windows.Forms.TextBox tb_Holiday;
        private System.Windows.Forms.Button add_button_holiday;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}