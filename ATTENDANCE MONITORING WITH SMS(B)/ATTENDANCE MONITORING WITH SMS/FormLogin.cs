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

namespace LUBANG_ATTENDANCE
{
    public partial class FormLogin : Form
    {
        private int loginAttempts = 0;

        public FormLogin()
        {
            InitializeComponent();
        }

        public string UserName
        {
            get { return textBoxUsername.Text; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.textBoxUsername.Text == "" || this.textBoxPassword.Text == "")
            {
                MessageBox.Show("All fields are required!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
                    string query = "SELECT * FROM table_user WHERE USERNAME='" + this.textBoxUsername.Text + "' AND PASSWORD='" + this.textBoxPassword.Text + "'";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // Reset the login attempts on successful login
                        loginAttempts = 0;

                        DataRow row = dt.Rows[0];
                        MessageBox.Show("Welcome: " + row["FIRSTNAME"].ToString() + " " + row["MI"].ToString() + " " + row["LASTNAME"].ToString(), "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        FormAdmin.FormHome FormHome = new FormAdmin.FormHome(UserName);
                        if (FormHome.ShowDialog() != DialogResult.OK)
                            return;
                        FormHome.Show();
                    }
                    else
                    {
                        loginAttempts++;

                        if (loginAttempts >= 3)
                        {
                            MessageBox.Show("Login timeout. Too many unsuccessful login attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close(); // Close the current login form
                            FormCheckInOut formCheckInOut = new FormCheckInOut();
                            formCheckInOut.Show(); // Show the FormCheckInOut
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Account does not exist! Attempt " + loginAttempts + " of 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCheckInOut FormCheckInOut = new FormCheckInOut();
            FormCheckInOut.Show();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}