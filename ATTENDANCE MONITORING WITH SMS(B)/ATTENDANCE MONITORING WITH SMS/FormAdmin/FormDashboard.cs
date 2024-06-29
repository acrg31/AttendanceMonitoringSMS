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
    public partial class FormDashboard : Form
    {
  
        public FormDashboard()
        {
            InitializeComponent();



           
        }
        IEnumerable<DateTime> GetDaysBetween(DateTime start, DateTime end)
        {
            for (DateTime i = start; i <= end; i = i.AddDays(1))
            {
                yield return i;
            }
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=lubang_db;SslMode=none");
       
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        string sql;


        private void loadData(string sql)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                //dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }
        }


        private void loadinfo()
        {
            try
            {
   
                sql = "SELECT CONCAT(LASTNAME,', ',FIRSTNAME,' ',MI) AS NAME, YEARLEVEL, SECTION, CONTACT, LOGDATE, TIMEIN AS ARRIVAL, TIMEOUT AS DEPARTURE FROM table_logged LEFT JOIN table_student ON table_logged.QRCODE = table_student.QRCODE WHERE DATE(`LOGDATE`) =CURDATE() ORDER BY LOGDATE DESC";
                loadData(sql);
                if (dt.Rows.Count > 0)
                {
                    iconButtonTodayInOut.Text = dt.Rows.Count.ToString();
                }
                else
                {
                    iconButtonTodayInOut.Text = "0";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                sql = "SELECT * FROM  table_logged WHERE ATTENDACE_STATUS='Late' AND DATE(`LOGDATE`) =CURDATE()";
                loadData(sql);
                if (dt.Rows.Count > 0)
                {
                    iconButtonTotalInOut.Text = dt.Rows.Count.ToString();
                }
                else
                {
                    iconButtonTotalInOut.Text = "0";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            try
            {

                sql = "SELECT * FROM table_student";
                loadData(sql);

                if (dt.Rows.Count > 0)
                {
                    iconButtonStudent.Text = dt.Rows.Count.ToString();
                }
                else
                {
                    iconButtonStudent.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {

                sql = "SELECT * FROM table_logged WHERE ATTENDACE_STATUS ='Present' AND DATE(`LOGDATE`) =CURDATE()";
                loadData(sql);

                if (dt.Rows.Count > 0)
                {
                    iconButtonUsers.Text = dt.Rows.Count.ToString();
                }
                else
                {
                    iconButtonUsers.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void FormDashboard_Load(object sender, EventArgs e)
        {
            loadinfo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadinfo();
        }

        private void iconButtonStudent_Click(object sender, EventArgs e)
        {
            FormPresent formPresent = new FormPresent();

            // Show FormPresent
            formPresent.Show();
        }

        private void iconButtonTodayInOut_Click(object sender, EventArgs e)
        {
            FormInOut FormInOut = new FormInOut();

            // Show FormPresent
            FormInOut.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }

        private void lbl_day_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {

        }


        private void btnAddHoliday_Click(object sender, EventArgs e)
        {
            // Open the form to add a new holiday
            FormAddHoliday formAddHoliday = new FormAddHoliday();
            formAddHoliday.ShowDialog();

            // Reload the dashboard data after adding a holiday (optional)
            loadinfo();
        }
    }
}
