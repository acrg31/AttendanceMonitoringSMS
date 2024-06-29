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
    public partial class FormMember : Form
    {
        public FormMember()
        {
            InitializeComponent();
        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
            string query = "SELECT USERID,CONCAT(FIRSTNAME, ' ', MI, ' ', LASTNAME) as NAME,ROLE, USERNAME, PASSWORD FROM table_user WHERE ROLE !='Administrator'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dataGridView1.Columns[e.ColumnIndex].Name;
            Form formodal = new Form();
            if (colname == "Column9")
            {
                try
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    string USERID = Convert.ToString(row.Cells["Column1"].Value.ToString());
                    DialogResult res = MessageBox.Show("Are you sure you want to Delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {

                        string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
                        string query = "DELETE FROM table_user WHERE USERID='" + USERID + "'";
                        MySqlConnection conn = new MySqlConnection(connection);
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        MySqlDataReader dr;
                        conn.Open();
                        dr = cmd.ExecuteReader();
                        MessageBox.Show("Record has been updated Delete", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        LoadData();

                    }
                    if (res == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (colname == "Column8")
            {
                try
                {
                 
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                 
                    string qrcode = Convert.ToString(row.Cells["Column1"].Value.ToString());
                    FormMemberEdit ViewFormEdit = new FormMemberEdit(qrcode);
                    ViewFormEdit.ShowDialog();
                }
                catch (Exception)
                {
                }
                finally
                {
                    formodal.Dispose();
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormNewMember EventRefresh = new FormNewMember(this);
            EventRefresh.ShowDialog();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
            string query = "SELECT USERID,CONCAT(FIRSTNAME, ' ', MI, ' ', LASTNAME) as NAME,ROLE, USERNAME, PASSWORD FROM table_user WHERE FIRSTNAME LIKE '%" + textBoxSearch.Text + "%' OR USERNAME LIKE '%" + textBoxSearch.Text + "%'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
