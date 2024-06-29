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
    public partial class FormNewMember : Form
    {
   
        private readonly FormMember formEventRefresh;
        public FormNewMember(FormMember EventRefresh)
        {
            InitializeComponent();
            formEventRefresh = EventRefresh;
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUsername.Text))
            {
                MessageBox.Show("Username is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(textBoxFirstName.Text))
            {
                MessageBox.Show("First Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(textBoxLastName.Text))
            {
                MessageBox.Show("Last Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(comboBoxRole.Text))
            {
                MessageBox.Show("Role is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string query = "SELECT * FROM table_user WHERE USERNAME='" + this.textBoxUsername.Text + "'";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    conn.Open();
                    da.Fill(dt);
                    conn.Close();
                    if (dt.Rows.Count > 0)
                    {
                        labelMassage.Visible = true;
                        labelMassage.Text = "Username: " + textBoxUsername.Text + " is already exist in database!";
                    }
                    else
                    {
                        labelMassage.Visible = false;
                        string connInsert = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
                        string inquery = "INSERT INTO table_user(FIRSTNAME,MI,LASTNAME,ROLE,USERNAME,PASSWORD)VALUES('" + this.textBoxFirstName.Text + "','" + this.textBoxMI.Text + "','" + this.textBoxLastName.Text + "','" + this.comboBoxRole.Text + "','" + this.textBoxUsername.Text + "','" + textBoxPassword.Text + "')";
                        MySqlConnection inconn = new MySqlConnection(connInsert);
                        MySqlCommand incmd = new MySqlCommand(inquery, inconn);
                        MySqlDataReader indr;
                        inconn.Open();
                        indr = incmd.ExecuteReader();
                        MessageBox.Show("New user Successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        inconn.Close();
                        

                        textBoxFirstName.Text = "";
                        textBoxLastName.Text = "";
                        textBoxMI.Text = "";
                        textBoxPassword.Text = "";
                        textBoxUsername.Text = "";
                        formEventRefresh.LoadData();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
