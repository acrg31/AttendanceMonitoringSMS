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
using MySql.Data.MySqlClient;

namespace LUBANG_ATTENDANCE.FormAdmin
{
    public partial class FormStudProf : Form
    {
        public FormStudProf( string qrcode)
        {
            InitializeComponent();
            textBoxUserID.Text = qrcode;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textqrImageFileName.Text))
            {
                MessageBox.Show("No image selected!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(textBoxUserID.Text))
            {
                MessageBox.Show("No Id Selected!!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
                    string query = "UPDATE table_student SET PROFILE='" + Path.GetFileName(pictureBoxQrcode.ImageLocation) + "' WHERE QRCODE ='" + textBoxUserID.Text + "'";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader dr;
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Successfully Updated", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    File.Copy(textqrImageFileName.Text, @"C:\QRcodeAttendance\Profile\" + Path.GetFileName(pictureBoxQrcode.ImageLocation));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Image Files(*.png;*.jpg;*.jpeg;*.gif;) | *.png;*.jpg;*.jpeg;*.gif;";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                textqrImageFileName.Text = openfd.FileName;
                pictureBoxQrcode.Image = new Bitmap(openfd.FileName);
                pictureBoxQrcode.ImageLocation = openfd.FileName;
                pictureBoxQrcode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
