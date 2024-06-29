using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using System.IO;
using ZXing;

namespace LUBANG_ATTENDANCE.FormAdmin
{
    public partial class FormStudentAdd : Form
    {

        public FormStudentAdd()
        {
            InitializeComponent();
            textBoxQRCODE.TextChanged += textBoxQRCODE_TextChanged;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxQRCODE.Text))
            {
                MessageBox.Show("Student Number is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBoxFileLocation.Text))
            {
                MessageBox.Show("Profile Image is  required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(textBoxFirstName.Text))
            {
                MessageBox.Show("First Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(textBoxLastName.Text))
            {
                MessageBox.Show("Last Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (String.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Designation is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
                    string query = "SELECT * FROM table_student WHERE QRCODE='" + this.textBoxQRCODE.Text + "'";
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
                        MessageBox.Show("Student number: " + textBoxQRCODE.Text + " is already exist in database!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        string connInsert = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
                        string inquery = "INSERT INTO table_student(QRCODE,FIRSTNAME,MI,LASTNAME,GENDER,AGE,DOB,YEARLEVEL,SECTION,ADDRESS,CONTACT,PROFILE,IMAGE)VALUES('" + this.textBoxQRCODE.Text + "','" + this.textBoxFirstName.Text + "','" + this.textBoxMI.Text + "','" + this.textBoxLastName.Text + "','" + this.comboBoxGender.Text + "','" + this.textBoxAge.Text + "','" + textBoxDOB.Text + "','" + cmbYrlvl.Text + "','" + cmbSection.Text + "','" + textBoxAddress.Text + "','" + textBoxContact.Text + "','" + Path.GetFileName(pictureBoxProfile.ImageLocation) + "','" + textBoxQRCODE.Text + ".png')";
                        MySqlConnection inconn = new MySqlConnection(connInsert);
                        MySqlCommand incmd = new MySqlCommand(inquery, inconn);
                        MySqlDataReader indr;
                        inconn.Open();
                        indr = incmd.ExecuteReader();
                        MessageBox.Show("New student Successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        inconn.Close();
                        this.Close();

                        textBoxFirstName.Text = "";
                        textBoxLastName.Text = "";
                        textBoxMI.Text = "";
                        textBoxAddress.Text = "";
                        textBoxAge.Text = "";
                        textBoxQRCODE.Text = "";
                        cmbYrlvl.SelectedValue = -1;
                        cmbSection.SelectedIndex = -1;
                        File.Copy(textBoxFileLocation.Text, @"C:\QRcodeAttendance\Profile\" + Path.GetFileName(pictureBoxProfile.ImageLocation));

                    }
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
                textBoxFileLocation.Text = openfd.FileName;
                pictureBoxProfile.Image = new Bitmap(openfd.FileName);
                pictureBoxProfile.ImageLocation = openfd.FileName;
                pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string qrData = textBoxQRCODE.Text.ToString();
            string qrImageFileName = textBoxQRCODE.Text.ToString();

            if (string.IsNullOrEmpty(qrData) || string.IsNullOrEmpty(qrImageFileName))
            {
                MessageBox.Show("Select student first to generate qrcode.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (File.Exists(@"C:\QRcodeAttendance\StudentQrcode\" + qrImageFileName + ".png"))
            {

                DialogResult res = MessageBox.Show("File already exists!. \nAre you sure do you want to replace?.", "Exists", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    File.Delete(@"C:\QRcodeAttendance\StudentQrcode\" + qrImageFileName + ".png");
                    BarcodeWriter barcodeW = new BarcodeWriter();
                    barcodeW.Format = BarcodeFormat.QR_CODE;
                    barcodeW.Write(qrData).Save(@"C:\QRcodeAttendance\StudentQrcode\" + qrImageFileName + ".png");
                    pictureBoxQrcode.Image = Image.FromFile(@"C:\QRcodeAttendance\StudentQrcode\" + qrImageFileName + ".png");

                    MessageBox.Show("Successfully Generated", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (res == DialogResult.Cancel)
                {
                    return;
                }

            }
            else
            {

                BarcodeWriter barcodeW = new BarcodeWriter();
                barcodeW.Format = BarcodeFormat.QR_CODE;
                barcodeW.Write(qrData).Save(@"C:\QRcodeAttendance\StudentQrcode\" + qrImageFileName + ".png");
                pictureBoxQrcode.Image = Image.FromFile(@"C:\QRcodeAttendance\StudentQrcode\" + qrImageFileName + ".png");

                MessageBox.Show("Successfully Generated", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBoxDOB_ValueChanged(object sender, EventArgs e)
        {
            int Age = DateTime.Today.Year - textBoxDOB.Value.Year; // CurrentYear - BirthDate

            textBoxAge.Text = Age.ToString();
        }

        private void textBoxQRCODE_TextChanged(object sender, EventArgs e)
        {
            // Check if the entered text is not numeric
            if (!IsNumeric(textBoxQRCODE.Text))
            {
                // If not numeric, remove the last entered character
                textBoxQRCODE.Text = textBoxQRCODE.Text.Length > 0
                    ? textBoxQRCODE.Text.Substring(0, textBoxQRCODE.Text.Length - 1)
                    : string.Empty;

                // Set the cursor position to the end
                textBoxQRCODE.SelectionStart = textBoxQRCODE.Text.Length;
            }
        }

        // Function to check if a string is numeric
        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        private void FormStudentAdd_Load(object sender, EventArgs e)
        {
            
        }
    }
}