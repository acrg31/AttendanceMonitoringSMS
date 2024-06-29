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
namespace LUBANG_ATTENDANCE.FormMessages
{
    public partial class FormAttendance : Form
    {
        public FormAttendance()
        {
            InitializeComponent();
        }

        private void FormAttendance_Load(object sender, EventArgs e)
        {
                LoadData();
        }

        public void LoadData()
        {
            try
            {
                string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
                MySqlConnection con = new MySqlConnection(connection);
                MySqlDataAdapter da;
                DataTable dt;
                con.Open();
                da = new MySqlDataAdapter("SELECT QRCODE, LOGDATE,TIMEIN, AM_STATUS, TIMEOUT, PM_STATUS FROM table_logged ORDER BY LOGDATE DESC", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
            string query = "SELECT QRCODE, LOGDATE,TIMEIN, AM_STATUS, TIMEOUT, PM_STATUS FROM table_logged WHERE QRCODE LIKE'%" + this.textBoxSearch.Text + "%' OR LOGDATE LIKE'%" + this.textBoxSearch.Text + "%'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                labelMessage.Visible = false;
            }
            else
            {
                labelMessage.Visible = true;
                labelMessage.Text = "No result found";
            }
        }

        private void btnDeleteLogs_Click(object sender, EventArgs e)
        {
            string message = "Are you you sure do you want to clear all attendance logs?";
            string title = "Delete Logs";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
                string query = "DELETE FROM table_logged";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                //MessageBox.Show("Data has been succesfully deleted!!");
                conn.Close();
            }
            else
            {
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
