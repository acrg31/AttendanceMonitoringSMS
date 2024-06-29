using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;

namespace LUBANG_ATTENDANCE.FormAdmin
{
    public partial class FormIDPreview : Form
    {
       // private int currentPage = 1;
        Bitmap bitmap;
        
        public FormIDPreview(string qrcode)
        {
            InitializeComponent();
            labelQrcode.Text = qrcode;
            
        }

        public void print()
        {
            
            //Add a Panel control.
            Panel panel = new Panel();
            this.Controls.Add(panel);

            //Create a Bitmap of size same as that of the Form.
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);

            //Copy screen area that that the Panel covers.
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            return;


        }

        private void FormIDPreview_Load(object sender, System.EventArgs e)
        {
            loadinfo();
            textBoxYearLevel.CharacterCasing = CharacterCasing.Upper;
            labelQrcode.CharacterCasing = CharacterCasing.Upper;
            textBoxSection.CharacterCasing = CharacterCasing.Upper;
           // textBoxContact.CharacterCasing = CharacterCasing.Upper;

        }
        public void loadinfo()
        {
            string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none";
            string query = "SELECT * FROM table_student WHERE QRCODE='" + this.labelQrcode.Text.ToString() + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            //comboBoxGender.Items.Clear();
            if (dt.Rows.Count > 0)
            {

                if (string.IsNullOrEmpty(dt.Rows[0]["IMAGE"].ToString()))
                {
                    pictureBoxEmpty.Visible = true;
                    pictureBoxHas.Visible = false;
                }
                else
                {
                    pictureBoxEmpty.Visible = false;
                    pictureBoxHas.Visible = true;
                    pictureBoxHas.ImageLocation = @"D:\QRcodeAttendance\StudentQrcode\" + dt.Rows[0]["IMAGE"].ToString();
                }

                if (string.IsNullOrEmpty(dt.Rows[0]["PROFILE"].ToString()))
                {
                    photonotavailable.Visible = true;
                    pictureBoxProfe.Visible = false;
                }
                else
                {
                    photonotavailable.Visible = false;
                    pictureBoxProfe.Visible = true;
                    pictureBoxProfe.ImageLocation = @"D:\QRcodeAttendance\Profile\" + dt.Rows[0]["PROFILE"].ToString();
                }


                labelFullname.Text = dt.Rows[0]["FIRSTNAME"].ToString() + " " + dt.Rows[0]["MI"].ToString() + " " + dt.Rows[0]["LASTNAME"].ToString();
                ///textBoxFirstName.Text = dt.Rows[0]["FIRSTNAME"].ToString();
               // textBoxMI.Text = dt.Rows[0]["MI"].ToString();
                //textBoxLastName.Text = dt.Rows[0]["LASTNAME"].ToString();
               // comboBoxGender.Text = dt.Rows[0]["GENDER"].ToString();
               // textBoxAge.Text = dt.Rows[0]["AGE"].ToString();
              //  dateTimePickerDOB.Text = dt.Rows[0]["DOB"].ToString();
                textBoxYearLevel.Text = dt.Rows[0]["YEARLEVEL"].ToString();
                textBoxSection.Text = dt.Rows[0]["DOB"].ToString();


              //  textBoxContact.Text = dt.Rows[0]["CONTACT"].ToString();

                if (string.IsNullOrEmpty(dt.Rows[0]["GENDER"].ToString()))
                {
                    Gender.Text = "N/A";
                }
                else
                {
                    Gender.Text = dt.Rows[0]["GENDER"].ToString();
                }

            }
            else
            {
                if (labelQrcode.Text == "")
                {
                    MessageBox.Show("Select Student to Edit!!");
                    this.Close();
                }
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            // e.Graphics.DrawImage(bitmap, e.PageBounds);
            e.Graphics.DrawImage(bitmap, 50,50);

        }

        private void photonotavailable_Click(object sender, System.EventArgs e)
        {
            this.print();
        }

        private void label4_Click(object sender, System.EventArgs e)
        {

        }
    }


}
