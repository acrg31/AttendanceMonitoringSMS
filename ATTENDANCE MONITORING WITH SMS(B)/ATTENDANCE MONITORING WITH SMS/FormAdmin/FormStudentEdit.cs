using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LUBANG_ATTENDANCE.FormAdmin
{
    public partial class FormStudentEdit : Form
    {
        public FormStudentEdit()
        {
        }
        public FormStudentEdit(string qrcode)
        {
            InitializeComponent();
            labelQrcode.Text = qrcode;
        }

        private void FormStudentEdit_Load(object sender, EventArgs e)
        {
            loadinfo();
        }
        public void loadinfo()
        {
            string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
            string query = "SELECT * FROM table_student WHERE QRCODE='" + this.labelQrcode.Text.ToString() + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
      //   comboBoxGender.Items.Clear();
            if (dt.Rows.Count > 0)
            {
                labelFullname.Text = dt.Rows[0]["FIRSTNAME"].ToString() + " " + dt.Rows[0]["MI"].ToString() + " " + dt.Rows[0]["LASTNAME"].ToString();
                textBoxFirstName.Text = dt.Rows[0]["FIRSTNAME"].ToString();
                textBoxMI.Text = dt.Rows[0]["MI"].ToString();
                textBoxLastName.Text = dt.Rows[0]["LASTNAME"].ToString();
                comboBoxGender.Text = dt.Rows[0]["GENDER"].ToString();
                textBoxAge.Text = dt.Rows[0]["AGE"].ToString();
                // dateTimePickerDOB.Value =dt.Rows[0]["DOB"].ToString();
                textBoxDOB.Text=dt.Rows[0]["DOB"].ToString();
                textBoxYearLevel.Text = dt.Rows[0]["YEARLEVEL"].ToString();
                textBoxSection.Text = dt.Rows[0]["SECTION"].ToString();
                textBoxAddress.Text = dt.Rows[0]["ADDRESS"].ToString();
                textBoxContact.Text = dt.Rows[0]["CONTACT"].ToString();

            }
            else
            {
                if (labelQrcode.Text =="") { 
                MessageBox.Show("Select Student to Edit!!");
                  this.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxFirstName.Text))
            {
                MessageBox.Show("First Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(textBoxLastName.Text))
            {
                MessageBox.Show("Last Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Designation is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
            try
                {
                    string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none;Allow Zero Datetime=true";
                    string query = "UPDATE table_student SET FIRSTNAME='" + this.textBoxFirstName.Text + "',MI='" + this.textBoxMI.Text + "',LASTNAME='" + this.textBoxLastName.Text + "',GENDER='" + this.comboBoxGender.Text + "',AGE='" + this.textBoxAge.Text + "',DOB='" + this.textBoxDOB.Text + "',YEARLEVEL='" + this.textBoxYearLevel.Text + "',SECTION='" + this.textBoxSection.Text + "', ADDRESS='" + this.textBoxAddress.Text + "',CONTACT='" + textBoxContact.Text + "' WHERE QRCODE='" + this.labelQrcode.Text + "'";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader dr;
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Record has been updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDOB_ValueChanged(object sender, EventArgs e)
        {
            int Age = DateTime.Today.Year - textBoxDOB.Value.Year; // CurrentYear - BirthDate

            textBoxAge.Text = Age.ToString();
        }
    }
}
