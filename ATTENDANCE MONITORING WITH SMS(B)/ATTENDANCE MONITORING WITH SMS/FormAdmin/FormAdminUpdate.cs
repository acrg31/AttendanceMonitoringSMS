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
    public partial class FormAdminUpdate : Form
    {
        public FormAdminUpdate()
        {
        }

        public FormAdminUpdate(string USERID)
        {
            InitializeComponent();
            labelUserID.Text = USERID;
        }

        private void FormAdminUpdate_Load(object sender, EventArgs e)
        {
            loadinfo();
        }
        public void loadinfo()
        {
            string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
            string query = "SELECT * FROM table_user WHERE USERID='" + labelUserID.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxRole.Items.Clear();
            if (dt.Rows.Count > 0)
            {
                ///labelFullname.Text = dt.Rows[0]["FIRSTNAME"].ToString() + " " + dt.Rows[0]["MI"].ToString() + " " + dt.Rows[0]["LASTNAME"].ToString();
                textBoxFirstName.Text = dt.Rows[0]["FIRSTNAME"].ToString();
                textBoxMI.Text = dt.Rows[0]["MI"].ToString();
                textBoxLastName.Text = dt.Rows[0]["LASTNAME"].ToString();
                comboBoxRole.Text = dt.Rows[0]["ROLE"].ToString();
                textBoxUsername.Text = dt.Rows[0]["USERNAME"].ToString();
                textBoxPassword.Text = dt.Rows[0]["PASSWORD"].ToString();
                //textBoxYearLevel.Text = dt.Rows[0]["YEARLEVEL"].ToString();
                //textBoxSection.Text = dt.Rows[0]["SECTION"].ToString();
                //textBoxPhoneNo.Text = dt.Rows[0]["PARENTNUM"].ToString();
                // textBoxAddress.Text = dt.Rows[0]["ADDRESS"].ToString();

            }
            else
            {
                if (labelUserID.Text == "")
                {
                    MessageBox.Show("Select User to Edit!!");
                    this.Close();
                }
            }
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
                    string query = "UPDATE table_user SET FIRSTNAME='" + this.textBoxFirstName.Text + "',MI='" + this.textBoxMI.Text + "',LASTNAME='" + this.textBoxLastName.Text + "',ROLE='" + this.comboBoxRole.Text + "',USERNAME='" + this.textBoxUsername.Text + "',PASSWORD='" + this.textBoxPassword.Text + "' WHERE USERID='" + labelUserID.Text + "'";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader dr;
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Information has been updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
