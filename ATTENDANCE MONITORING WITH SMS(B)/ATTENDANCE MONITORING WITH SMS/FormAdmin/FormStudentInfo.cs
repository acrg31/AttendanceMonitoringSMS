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
    public partial class FormStudentInfo : Form
    {
        public FormStudentInfo()
        {

        }
        public FormStudentInfo(string qrcode)
        {
            InitializeComponent();
            labelQrcode.Text = qrcode;
        }
        
        private void FormStudentInfo_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlDataAdapter da;
            DataTable dt;
            con.Open();
            da = new MySqlDataAdapter("SELECT * FROM table_student WHERE QRCODE='" + this.labelQrcode.Text+ "'", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                if (string.IsNullOrEmpty(dt.Rows[0]["PROFILE"].ToString()))
                {
                    pictureBoxEmpty.Visible = true;
                    pictureBoxHas.Visible = false;
                }
                else 
                {
                    pictureBoxEmpty.Visible = false;
                    pictureBoxHas.Visible = true;
                    pictureBoxHas.ImageLocation =@"D:\QRcodeAttendance\Profile\" + dt.Rows[0]["PROFILE"].ToString();
                }
                if (string.IsNullOrEmpty(dt.Rows[0]["IMAGE"].ToString()))
                {
                    qrcodeNotAvailable.Visible = true;
                    pictureBoxQrcode.Visible = false;
                }
                else
                {
                    qrcodeNotAvailable.Visible = false;
                    pictureBoxQrcode.Visible = true;
                    pictureBoxQrcode.ImageLocation =@"D:\QRcodeAttendance\StudentQrcode\" + dt.Rows[0]["IMAGE"].ToString();
                }

                labelFullName.Text = dt.Rows[0]["FIRSTNAME"].ToString() + " " + dt.Rows[0]["MI"].ToString() + " " + dt.Rows[0]["LASTNAME"].ToString();
                labelGender.Text = dt.Rows[0]["GENDER"].ToString();
                labelAge.Text = dt.Rows[0]["AGE"].ToString();
                labelDOB.Text = dt.Rows[0]["DOB"].ToString();
                labelYearLevel.Text = dt.Rows[0]["YEARLEVEL"].ToString();
                labelSection.Text = dt.Rows[0]["SECTION"].ToString();
                labelPentNo.Text = dt.Rows[0]["CONTACT"].ToString();
                
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
