using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUBANG_ATTENDANCE
{
    public partial class FormPresent : Form
    {
        public FormPresent()
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

        private void searchB_TextChanged(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
            string query = "SELECT QRCODE FROM table_logged WHERE QRCODE LIKE '%" + this.searchB.Text + "%' OR LOGDATE LIKE '%" + this.searchB.Text + "%'";
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

        private void FormPresent_Load(object sender, EventArgs e)
        {

        }

        private void labelMessage_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
