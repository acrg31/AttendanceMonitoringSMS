using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZXing;
using MySql.Data.MySqlClient;

namespace LUBANG_ATTENDANCE.FormAdmin
{
    public partial class FormStudentQrcode : Form
    {
        public FormStudentQrcode()
        {
        }
        public FormStudentQrcode( string qrcode,string fullname)
        {
            InitializeComponent();
            textBoxQrcode.Text = qrcode;
            textqrImageFileName.Text = fullname;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string qrData = textBoxQrcode.Text.ToString();
            string qrImageFileName = textqrImageFileName.Text.ToString();

            if (string.IsNullOrEmpty(qrData) || string.IsNullOrEmpty(qrImageFileName))
            {
                MessageBox.Show("Select student first to generate qrcode.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (File.Exists(@"C:\QRcodeAttendance\StudentQrcode\" + qrImageFileName + ".png"))
            {
                // File.Delete(@"C:\Temp\Data\Authors.txt");
                // MessageBox.Show("File already exists! \nChoose another name.", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //return;

                DialogResult res = MessageBox.Show("File already exists!. \nAre you sure do you want to replace?.", "Exists", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    File.Delete(@"C:\QRcodeAttendance\StudentQrcode\" + qrImageFileName + ".png");
                    BarcodeWriter barcodeW = new BarcodeWriter();
                    barcodeW.Format = BarcodeFormat.QR_CODE;
                    barcodeW.Write(qrData).Save(@"C:\QRcodeAttendance\StudentQrcode\" + qrImageFileName + ".png");
                    pictureBoxQrcode.Image = Image.FromFile(@"C:\QRcodeAttendance\StudentQrcode\" + qrImageFileName + ".png");

                    string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
                    string query = "UPDATE table_student SET IMAGE='" + qrImageFileName + ".png' WHERE QRCODE ='" + qrData + "'";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader dr;
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    conn.Close();
                    //File.Copy(textqrImageFileName.Text, Application.StartupPath + @"\qrcode\" + Path.GetFileName(pictureBoxQrcode.ImageLocation));
                    MessageBox.Show("Successfully Generated and saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (res == DialogResult.Cancel)
                {
                    return;
                }

            }else {

                BarcodeWriter barcodeW = new BarcodeWriter();
                barcodeW.Format = BarcodeFormat.QR_CODE;
                barcodeW.Write(qrData).Save(@"C:\QRcodeAttendance\StudentQrcode\" + qrImageFileName + ".png");
                pictureBoxQrcode.Image = Image.FromFile(@"C:\QRcodeAttendance\StudentQrcode\" + qrImageFileName + ".png");

                string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
                string query = "UPDATE table_student SET IMAGE='" + qrImageFileName + ".png' WHERE QRCODE ='" + qrData + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                conn.Close();
                //File.Copy(textqrImageFileName.Text, Application.StartupPath + @"\qrcode\" + Path.GetFileName(pictureBoxQrcode.ImageLocation));
                MessageBox.Show("Successfully Generated and saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FormStudentQrcode_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
