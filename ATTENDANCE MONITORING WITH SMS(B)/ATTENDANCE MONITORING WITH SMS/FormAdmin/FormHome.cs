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
    public partial class FormHome : Form
    {
        public FormHome(string userName)
        {
            InitializeComponent();
            labelFullName.Text = userName;
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
          
            
            change_menu("DASHBOARD");
            loadinfo();
        }

        private void loadinfo()
        {
            try
            {
                string connection = "server=localhost;user id=root;password=;database=lubang_db;SslMode=none;Convert Zero Datetime=true;Persist Security Info=True;Allow Zero Datetime=True";
                string query = "SELECT * FROM table_user WHERE USERNAME='" + this.labelFullName.Text + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                   // labelName.Text = row["FIRSTNAME"].ToString() + " " + row["MI"].ToString() + " " + row["LASTNAME"].ToString();
                   // labelRole.Text = row["ROLE"].ToString();
                    labelUserID.Text = row["USERID"].ToString();
                }
                else
                {
                   // labelName.Text = "[]";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void addForm(Form frm)
        {
            panelContainer.Controls.Clear();
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            panelContainer.Controls.Add(frm);
            frm.Show();
        }

        private void change_menu(string menu)
        {
            switch (menu)
            {
                case "DASHBOARD":
                    {
                        lblTitle.Text = "DASHBOARD";
                        addForm(frm: new FormDashboard());
                        break;
                    }

                case "STUDENT":
                    {
                        lblTitle.Text = "STUDENTS RECORD";
                        addForm(frm: new FormStudent());
                        break;
                    }
          


                case "ATTENDANCE":
                    {
                        lblTitle.Text = "ATTENDANCE RECORD";
                        addForm(frm: new FormMessages.FormAttendance());
                        break;
                    }

                case "REPORTS":
                    {
                        lblTitle.Text = "REPORTS";
                        addForm(frm: new FormReport.FormReport());
                        break;
                    }
                case "MEMBER":
                    {
                        lblTitle.Text = "LIST OF MEMBER";
                        addForm(frm: new FormMember.FormMember());
                        break;
                    }
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            //ActiveButton(sender, RGBColors.color14);
            change_menu("DASHBOARD");
        }
        private void btnStudent_Click(object sender, EventArgs e)
        {
            change_menu("STUDENT");
        }


        private void btnAttendance_Click(object sender, EventArgs e)
        {
            change_menu("ATTENDANCE");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            change_menu("REPORTS");
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            change_menu("MEMBER");
        }

        
        private void btnPassword_Click(object sender, EventArgs e)
        {
            Form formodal = new Form();
            try
            {
                FormAdminUpdate modal = new FormAdminUpdate();
                //DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                //FormStudentEdit StudentProfile = new FormStudentEdit();
                formodal.StartPosition = FormStartPosition.Manual;
                formodal.FormBorderStyle = FormBorderStyle.None;
                formodal.Opacity = 0.5;
                formodal.BackColor = Color.Black;
                formodal.WindowState = FormWindowState.Maximized;
                //formodal.TopMost = true;
                formodal.Location = Location;
                formodal.ShowInTaskbar = false;
                formodal.Show();
                modal.Owner = formodal;
                string USERID = labelUserID.Text;
                FormAdminUpdate ViewFormEdit = new FormAdminUpdate(USERID);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadinfo();
        }

        
        private void btnSms_Click(object sender, EventArgs e)
        {
            FormSettings modal = new FormSettings();
            modal.ShowDialog();
        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            FormCheckInOut scrren = new FormCheckInOut();
            scrren.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Exit?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
            if (res == DialogResult.Cancel)
            {
                return;
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }

        private void btnMinize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMidTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
