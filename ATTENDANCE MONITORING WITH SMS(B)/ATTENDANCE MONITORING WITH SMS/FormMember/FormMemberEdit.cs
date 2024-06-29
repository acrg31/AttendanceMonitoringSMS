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

namespace LUBANG_ATTENDANCE.FormMember
{
    public partial class FormMemberEdit : Form
    {
        public FormMemberEdit(string qrcode)
        {
            InitializeComponent();
            labelQrcode.Text = qrcode;
        }
      
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxFirstName.Text))
            {
                MessageBox.Show("First Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(textBoxLastName.Text))
            {
                MessageBox.Show("Last Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(textBoxUsername.Text))
            {
                MessageBox.Show("Username is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Password is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
                    string query = "UPDATE table_user SET FIRSTNAME='" + this.textBoxFirstName.Text + "',MI='" + this.textBoxMI.Text + "',LASTNAME='" + this.textBoxLastName.Text + "',USERNAME='" + this.textBoxUsername.Text + "',PASSWORD='" + this.textBoxPassword.Text + "' WHERE USERID='" + this.labelQrcode.Text + "'";
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

        private void FormMemberEdit_Load(object sender, EventArgs e)
        {
        

                try
               {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=lubang_db;SslMode=none");
                    con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM  table_user WHERE USERID=?", con);
                   cmd.Parameters.AddWithValue("@USERID", int.Parse(labelQrcode.Text));
                MySqlDataReader dt = cmd.ExecuteReader();

                  while (dt.Read())
                  {
                    textBoxFirstName.Text = dt.GetValue(1).ToString();
                    textBoxMI.Text = dt.GetValue(2).ToString();
                    textBoxLastName.Text = dt.GetValue(3).ToString();
                    comboBoxRole.Text = dt.GetValue(4).ToString();
                    textBoxUsername.Text = dt.GetValue(5).ToString();
                    textBoxPassword.Text = dt.GetValue(6).ToString();
                }
                   con.Close();
                   
               }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message);
               }


        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
