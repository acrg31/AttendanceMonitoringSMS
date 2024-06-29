using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ZXing;

namespace LUBANG_ATTENDANCE.FormAdmin
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();

        }
        public void cmbItems()
        {
            cmbGender.Items.Add("F");
            cmbGender.Items.Add("M");
            cmbGender.SelectedIndex = -1;
            cmbG8Gender.Items.Add("F");
            cmbG8Gender.Items.Add("M");
            cmbG8Gender.SelectedIndex = -1;
            cmbg9Gender.Items.Add("F");
            cmbg9Gender.Items.Add("M");
            cmbg9Gender.SelectedIndex = -1;
            cmbG10Gender.Items.Add("F");
            cmbG10Gender.Items.Add("M");
            cmbG10Gender.SelectedIndex = -1;
        }
        private void FormStudent_Load(object sender, EventArgs e)
        {
            LoadDataG7();
            LoadDataG8();
            LoadDataG9();
            LoadDataG10();
            cmbItems();

        }


        public void LoadDataG7()
        {
            string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
            string query = "SELECT ID AS STUDENTID, CONCAT(LASTNAME,', ',FIRSTNAME,' ',MI) AS NAME, AGE, GENDER, DOB AS BIRTHDAY, QRCODE, PROFILE  FROM table_student WHERE YEARLEVEL='Grade 7'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgG7.DataSource = dt;
        }
        private void LoadDataG8()
        {
            string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
            string query = "SELECT ID AS STUDENTID, CONCAT(LASTNAME,', ',FIRSTNAME,' ',MI) AS NAME, AGE, GENDER, DOB AS BIRTHDAY, QRCODE, PROFILE  FROM table_student WHERE YEARLEVEL='Grade 8'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgG8.DataSource = dt;
        }
        private void LoadDataG9()
        {
            string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
            string query = "SELECT ID AS STUDENTID, CONCAT(LASTNAME,', ',FIRSTNAME,' ',MI) AS NAME, AGE, GENDER, DOB AS BIRTHDAY, QRCODE, PROFILE  FROM table_student WHERE YEARLEVEL='Grade 9'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgG9.DataSource = dt;
        }
        private void LoadDataG10()
        {
            string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
            string query = "SELECT ID AS STUDENTID, CONCAT(LASTNAME,', ',FIRSTNAME,' ',MI) AS NAME, AGE, GENDER, DOB AS BIRTHDAY, QRCODE, PROFILE  FROM table_student WHERE YEARLEVEL='Grade 10'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgG10.DataSource = dt;
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            Form NewStudModal = new Form();
            try
            {
                FormStudentAdd addmodal = new FormStudentAdd();
                NewStudModal.StartPosition = FormStartPosition.Manual;
                NewStudModal.FormBorderStyle = FormBorderStyle.None;
                NewStudModal.Opacity = 0.5;
                NewStudModal.BackColor = Color.Black;
                NewStudModal.WindowState = FormWindowState.Maximized;

                NewStudModal.Location = Location;
                NewStudModal.ShowInTaskbar = false;
                NewStudModal.Show();
                addmodal.Owner = NewStudModal;
                addmodal.ShowDialog();
                FormStudent_Load(sender, e);
            }
            catch (Exception)
            {
            }
            finally
            {
                NewStudModal.Dispose();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void oop(object sender, EventArgs e)
        {

        }

        private void tpG7_Click(object sender, EventArgs e)
        {

        }

        private void tpG8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
            string query = "SELECT ID AS STUDENTID, CONCAT(LASTNAME,', ',FIRSTNAME,' ',MI) AS NAME, AGE, GENDER, DOB AS BIRTHDAY, QRCODE, PROFILE FROM table_student WHERE ((QRCODE LIKE'%" + textBoxSearch.Text + "%' OR LASTNAME LIKE'%" + textBoxSearch.Text + "%')&&(YEARLEVEL='Grade 7')) ";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dgG7.DataSource = dt;
                //   labelMessage.Visible = false;
            }
            else
            {
                //  dgG7.Rows.Clear();
                //  labelMessage.Visible = true;
                //labelMessage.Text = "No result found";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgG10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tpG10_Click(object sender, EventArgs e)
        {

        }

        private void dgG7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = dgG7.Rows[e.RowIndex];
                txtID.Text = Row.Cells[0].Value.ToString();
                txtName.Text = Row.Cells[1].Value.ToString();
                cmbGender.Text = Row.Cells[3].Value.ToString();
                txtAge.Text = Row.Cells[2].Value.ToString();
                txtDOB.Text = Row.Cells[4].Value.ToString();

                {//FOR OUTPUTTING QR IN PB
                    BarcodeWriter barcodeW = new BarcodeWriter();
                    barcodeW.Format = BarcodeFormat.QR_CODE;

                    if (barcodeW != null)
                    {
                        Bitmap barcodeBitmap = barcodeW.Write(Row.Cells[5].Value.ToString());
                        pbQR.Image = barcodeBitmap;
                    }
                }
                //{//FOR OUTPUTTING IMG IN PB

                //    byte[] img = (byte[])(Row.Cells[6].Value);
                //    if (img != null)
                //    {
                //        MemoryStream ms = new MemoryStream(img);
                //        ms.Position = 0;
                //        pbStudID.Image = new Bitmap(ms);
                //    }
                //}
                //Under maintenance pa hahaha




            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dgG8_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = dgG8.Rows[e.RowIndex];
                txtG8studentID.Text = Row.Cells[0].Value.ToString();
                txtG8Name.Text = Row.Cells[1].Value.ToString();
                cmbG8Gender.Text = Row.Cells[3].Value.ToString();
                txtG8Age.Text = Row.Cells[2].Value.ToString();
                txtG8DOB.Text = Row.Cells[4].Value.ToString();

                {//FOR OUTPUTTING QR IN PB
                    BarcodeWriter barcodeW = new BarcodeWriter();
                    barcodeW.Format = BarcodeFormat.QR_CODE;

                    if (barcodeW != null)
                    {
                        Bitmap barcodeBitmap = barcodeW.Write(Row.Cells[5].Value.ToString());
                        pbG8qr.Image = barcodeBitmap;
                    }
                }
            }
        }

        private void dgG9_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = dgG9.Rows[e.RowIndex];
                txtG9studentID.Text = Row.Cells[0].Value.ToString();
                txtG9name.Text = Row.Cells[1].Value.ToString();
                cmbg9Gender.Text = Row.Cells[3].Value.ToString();
                txtg9Age.Text = Row.Cells[2].Value.ToString();
                txtg9DOB.Text = Row.Cells[4].Value.ToString();

                {//FOR OUTPUTTING QR IN PB
                    BarcodeWriter barcodeW = new BarcodeWriter();
                    barcodeW.Format = BarcodeFormat.QR_CODE;

                    if (barcodeW != null)
                    {
                        Bitmap barcodeBitmap = barcodeW.Write(Row.Cells[5].Value.ToString());
                        pbg9QR.Image = barcodeBitmap;
                    }
                }
            }
        }

        private void dgG10_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = dgG10.Rows[e.RowIndex];
                txtG10studentID.Text = Row.Cells[0].Value.ToString();
                txtG10Name.Text = Row.Cells[1].Value.ToString();
                cmbG10Gender.Text = Row.Cells[3].Value.ToString();
                txtG10age.Text = Row.Cells[2].Value.ToString();
                txtG10DOB.Text = Row.Cells[4].Value.ToString();

                {//FOR OUTPUTTING QR IN PB
                    BarcodeWriter barcodeW = new BarcodeWriter();
                    barcodeW.Format = BarcodeFormat.QR_CODE;

                    if (barcodeW != null)
                    {
                        Bitmap barcodeBitmap = barcodeW.Write(Row.Cells[5].Value.ToString());
                        pbG10studID.Image = barcodeBitmap;
                    }
                }
            }
        }

        private void txtSearch10_TextChanged(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
            string query = "SELECT ID AS STUDENTID, CONCAT(LASTNAME,', ',FIRSTNAME,' ',MI) AS NAME, AGE, GENDER, DOB AS BIRTHDAY, QRCODE, PROFILE FROM table_student WHERE ((QRCODE LIKE'%" + textBoxSearch.Text + "%' OR LASTNAME LIKE'%" + textBoxSearch.Text + "%')&&(YEARLEVEL='Grade 10')) ";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dgG10.DataSource = dt;
              
            }
            else
            {
                //  dgG7.Rows.Clear();
                //  labelMessage.Visible = true;
                //labelMessage.Text = "No result found";
            }
        }

        private void txtSearchG8_TextChanged(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
            string query = "SELECT ID AS STUDENTID, CONCAT(LASTNAME,', ',FIRSTNAME,' ',MI) AS NAME, AGE, GENDER, DOB AS BIRTHDAY, QRCODE, PROFILE FROM table_student WHERE ((QRCODE LIKE'%" + textBoxSearch.Text + "%' OR LASTNAME LIKE'%" + textBoxSearch.Text + "%')&&(YEARLEVEL='Grade 8')) ";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dgG8.DataSource = dt;

            }
            else
            {
                //  dgG7.Rows.Clear();
                //  labelMessage.Visible = true;
                //labelMessage.Text = "No result found";
            }
        }

        private void txtSearchG9_TextChanged(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
            string query = "SELECT ID AS STUDENTID, CONCAT(LASTNAME,', ',FIRSTNAME,' ',MI) AS NAME, AGE, GENDER, DOB AS BIRTHDAY, QRCODE, PROFILE FROM table_student WHERE ((QRCODE LIKE'%" + textBoxSearch.Text + "%' OR LASTNAME LIKE'%" + textBoxSearch.Text + "%')&&(YEARLEVEL='Grade 9')) ";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dgG9.DataSource = dt;

            }
            else
            {
                //  dgG7.Rows.Clear();
                //  labelMessage.Visible = true;
                //labelMessage.Text = "No result found";
            }
        }
    }
}