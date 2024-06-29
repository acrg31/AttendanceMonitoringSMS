using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.IO.Ports;
using System.Threading;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

using System.Collections.Generic;
using System.ComponentModel;

using System.Text;
using GsmComm.GsmCommunication;
using GsmComm.Interfaces;
using GsmComm.PduConverter;
using GsmComm.Server;
using System.IO;
using System.Management;

namespace LUBANG_ATTENDANCE
{

    public partial class FormCheckInOut : Form
    {
        private static string myConn = "server=localhost;user id=root;password=;database=lubang_db;";
        MySqlConnection con = new MySqlConnection(myConn);
        MySqlDataAdapter da;
        DataTable dt;
        string attendance_status = "";

        DateTime mytime = DateTime.Parse("14:40:00");
        public FormCheckInOut()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }



        public void DataBind()
        {

            string query = "SELECT * FROM table_logged";
            MySqlConnection conn = new MySqlConnection(myConn);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            // dataGridView1.DataSource = dt;
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (LabelMessage.Text == "You have already timein and timout for today!")
            {
                LabelMessage.Visible = false;
                lblStudentName.Visible = false;
                LabelBarcodeID.Visible = false;
                TextBoxBarcodeNum.Clear();
                labelAge.Visible = false;
                labelGender.Visible = false;
                labelGrade.Visible = false;
                labelSection.Visible = false;
                pictureBoxHas.Visible = false;
            }
            else if (LabelMessage.Text == "Succesfully LogOut")
            {
                LabelMessage.Visible = false;
                lblStudentName.Visible = false;
                LabelBarcodeID.Visible = false;
                TextBoxBarcodeNum.Clear();
                labelAge.Visible = false;
                labelGender.Visible = false;
                labelGrade.Visible = false;
                labelSection.Visible = false;
                pictureBoxHas.Visible = false;
            }
            else if (LabelMessage.Text == "Successfully Time In")
            {
                LabelMessage.Visible = false;
                lblStudentName.Visible = false;
                LabelBarcodeID.Visible = false;
                TextBoxBarcodeNum.Clear();
                labelAge.Visible = false;
                labelGender.Visible = false;
                labelGrade.Visible = false;
                labelSection.Visible = false;
                pictureBoxHas.Visible = false;
            }
            else if (LabelMessage.Text == "15 Minutes interval")
            {
                LabelMessage.Visible = false;
                lblStudentName.Visible = false;
                LabelBarcodeID.Visible = false;
                TextBoxBarcodeNum.Clear();
                labelAge.Visible = false;
                labelGender.Visible = false;
                labelGrade.Visible = false;
                labelSection.Visible = false;
                pictureBoxHas.Visible = false;
            }
            else if (LabelMessage.Text == "ID number not found in database!")
            {
                LabelMessage.Visible = false;
                TextBoxBarcodeNum.Clear();
            }
        }



        private void FormCheckInOut_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    this.Hide();
                    FormLogin FormLogin = new FormLogin();
                    FormLogin.ShowDialog();
                    break;

                case Keys.F10:
                    break;
                case Keys.F11:
                    break;
                case Keys.F12:
                    DialogResult res = MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (res == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    if (res == DialogResult.Cancel)
                    {
                        return;
                    }
                    break;
                default:
                    break;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.labelDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // lbl_time.Text = DateTime.Now.ToString("HH:mm:ss tt");
            lbl_time.Text = DateTime.Now.ToString("hh:mm");
            lbl_sec.Text = DateTime.Now.ToString("ss");
            lbl_day.Text = DateTime.Now.ToString("dddd");
            lbl_date.Text = DateTime.Now.ToString("M dd yyyy");
            labelPmAm.Text = DateTime.Now.ToString("tt");
        }


        private void FormCheckInOut_Load(object sender, EventArgs e)
        {

            TextBoxBarcodeNum.TabIndex = 0;
            TextBoxBarcodeNum.Focus();
            DataBind();
            this.Text = DateTime.Now.ToString("yyyy/M/dd").ToString();

            lblStudentName.Visible = false;
            LabelBarcodeID.Visible = false;
            labelAge.Visible = false;
            labelGender.Visible = false;
            labelGrade.Visible = false;
            labelSection.Visible = false;

            LabelMessage.Visible = false;
            pictureBoxEmpty.Visible = true;
            pictureBoxHas.Visible = false;


        }

        private void TextBoxBarcodeNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday || DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
                {
                    MessageBox.Show("No classes today. Scanning is not allowed on weekends.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }


            if (e.KeyChar == (char)13)
            {
                string LastStatus = "Punch-Out";
                string pm = "Punch-Out";
                string am = "Punch-In";

                try
                {

                    timer2.Start();
                    con.Open();
                    da = new MySqlDataAdapter("SELECT * FROM table_student WHERE QRCODE='" + TextBoxBarcodeNum.Text + "'", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        string contactNo;
                        DataRow row = dt.Rows[0];
                        contactNo = row["CONTACT"].ToString();

                        lblStudentName.Visible = true;
                        LabelBarcodeID.Visible = true;
                        labelAge.Visible = true;
                        labelGender.Visible = true;
                        labelGrade.Visible = true;
                        labelSection.Visible = true;

                        timer2.Interval = 10000;
                        LabelBarcodeID.Text = row["QRCODE"].ToString();
                        lblStudentName.Text = row["FIRSTNAME"].ToString() + " " + row["MI"].ToString() + " " + row["LASTNAME"].ToString();
                        labelAge.Text = row["AGE"].ToString();
                        labelGender.Text = row["GENDER"].ToString();
                        labelGrade.Text = row["YEARLEVEL"].ToString();
                        labelSection.Text = row["SECTION"].ToString();

                        if (string.IsNullOrEmpty(dt.Rows[0]["PROFILE"].ToString()))
                        {
                            pictureBoxEmpty.Visible = true;
                            pictureBoxHas.Visible = false;
                        }
                        else
                        {
                            pictureBoxEmpty.Visible = false;
                            pictureBoxHas.Visible = true;
                            pictureBoxHas.ImageLocation = @"D:\QRcodeAttendance\Profile\" + dt.Rows[0]["PROFILE"].ToString();
                        }

                        string smsMessageOut = lblStudentName.Text + " EXIT on " + DateTime.Now.ToString("MMMM dd, yyyy") + " @ " + DateTime.Now.ToString("hh:mm:ss tt") + ". From: MEI";
                        string smsMessageIn = lblStudentName.Text + "ENTER on " + DateTime.Now.ToString("MMMM dd, yyyy") + " @ " + DateTime.Now.ToString("hh:mm:ss tt") + ". From: MEI";
                        var timenow = DateTime.Now;
                        if ((timenow - mytime).TotalMinutes >= 4)
                        {
                            attendance_status = "Late";
                        }
                        else
                        {
                            attendance_status = "Present";
                        }

                        con.Open();
                        da = new MySqlDataAdapter("SELECT * FROM table_logged WHERE QRCODE='" + TextBoxBarcodeNum.Text + "' AND AM_STATUS='" + am + "' AND PM_STATUS='" + pm + "' AND LOGDATE = '" + Text + "'", con);
                        dt = new DataTable();
                        da.Fill(dt);
                        con.Close();
                        if (dt.Rows.Count > 0)
                        {

                            LabelMessage.Visible = true;
                            timer2.Interval = 10000;
                            LabelMessage.Text = "You have already timein and timout for today!";
                            LabelMessage.BackColor = Color.Crimson;
                            LabelMessage.ForeColor = Color.White;
                            TextBoxBarcodeNum.Clear();
                            pictureBoxEmpty.Visible = true;
                        }
                        else
                        {
                            con.Open();
                            da = new MySqlDataAdapter("SELECT * FROM table_logged WHERE QRCODE= '" + TextBoxBarcodeNum.Text + "' AND LOGDATE = '" + Text + "' AND AM_STATUS='" + am + "'", con);
                            dt = new DataTable();
                            da.Fill(dt);
                            con.Close();
                            if (dt.Rows.Count > 0)
                            {
                                LastStatus = dt.Rows[0]["PM_STATUS"].ToString();
                                var start = DateTime.Now;
                                var oldDate = DateTime.Parse(dt.Rows[0]["TIMEIN"].ToString());


                                if ((start - oldDate).TotalMinutes >= 2)

                                {

                                    con.Open();
                                    da = new MySqlDataAdapter("UPDATE table_logged SET TIMEOUT='" + DateTime.Now.ToString("hh:mm tt") + "', PM_STATUS='" + pm + "' WHERE QRCODE= '" + TextBoxBarcodeNum.Text + "' AND LOGDATE = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'", con);
                                    dt = new DataTable();
                                    da.Fill(dt);
                                    con.Close();

                                    LabelMessage.Visible = true;
                                    timer2.Interval = 10000;
                                    LabelMessage.Text = "Succesfully LogOut";
                                    LabelMessage.BackColor = Color.Green;
                                    LabelMessage.ForeColor = Color.White;
                                    TextBoxBarcodeNum.Clear();
                                    SendSMSCA(contactNo, smsMessageOut);
                                    pictureBoxEmpty.Visible = true;

                                }
                                else
                                {

                                    LabelMessage.Visible = true;
                                    timer2.Interval = 10000;
                                    LabelMessage.Text = "15 Minutes interval";
                                    LabelMessage.BackColor = Color.Crimson;
                                    LabelMessage.ForeColor = Color.White;
                                    TextBoxBarcodeNum.Clear();
                                    pictureBoxEmpty.Visible = true;
                                }


                            }
                            else
                            {
                                if (LastStatus == "Punch-Out")
                                {
                                    string query;
                                    query = "INSERT INTO table_logged(TIMEIN, LOGDATE, QRCODE,AM_STATUS,ATTENDACE_STATUS)VALUES('" + DateTime.Now.ToString("hh:mm tt") + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + LabelBarcodeID.Text + "','" + am + "','" + attendance_status + "')";
                                    MySqlCommand cmd = new MySqlCommand(query, con);
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();

                                    LabelMessage.Visible = true;
                                    timer2.Interval = 10000;
                                    LabelMessage.Text = "Successfully Time In";
                                    LabelMessage.BackColor = Color.Green;
                                    LabelMessage.ForeColor = Color.White;
                                    TextBoxBarcodeNum.Clear();
                                    SendSMSCA(contactNo, smsMessageIn);
                                    pictureBoxEmpty.Visible = true;

                                }
                            }
                        }
                    }
                    else
                    {
                        LabelMessage.Visible = true;
                        timer2.Interval = 10000;
                        LabelMessage.Text = "ID number not found in database!";
                        LabelMessage.BackColor = Color.Crimson;
                        LabelMessage.ForeColor = Color.White;
                        TextBoxBarcodeNum.Clear();
                        pictureBoxEmpty.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SendSMSCA(string strNumber, string strMessage)
        {

            string CELL_Number, SMS_Message;

            SmsSubmitPdu pdu1;

            try
            {

                if (FormSettings.comm.IsConnected() == true)
                {


                    CELL_Number = strNumber;
                    SMS_Message = strMessage;
                    try
                    {
                        pdu1 = new SmsSubmitPdu(SMS_Message, CELL_Number, "");
                        FormSettings.comm.SendMessage(pdu1);
                    }

                    catch (Exception)
                    {

                        FormSettings.comm.Close();


                    }


                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
            }


        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxBarcodeNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxHas_Click(object sender, EventArgs e)
        {

        }

        private void LabelBarcodeID_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_sec_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelPmAm_Click(object sender, EventArgs e)
        {

        }
    }
}