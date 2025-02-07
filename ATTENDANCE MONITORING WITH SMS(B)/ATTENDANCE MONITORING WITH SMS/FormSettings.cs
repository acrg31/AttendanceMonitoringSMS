﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using GsmComm.GsmCommunication;
using GsmComm.Interfaces;
using GsmComm.PduConverter;
using GsmComm.Server;
using System.Data.OleDb;

namespace LUBANG_ATTENDANCE
{
    public partial class FormSettings : Form
    {
        public static Int16 Comm_Port = 0;
        public static Int32 Comm_BaudRate = 0;
        public static Int32 Comm_TimeOut = 0;
        public static GsmCommMain comm;
        DataSet dataSet, dataSet1 = new DataSet();

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Setting the column grid for fetched data

           dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "COM Port";
           dataGridView1.Columns[1].Name = "Connected Device";
           dataGridView1.Columns[2].Name = "Max Baud Rate";
            dataGridView1.Columns[3].Name = "Time Out";
            dataGridView1.Columns[4].Name = "Status";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_SerialPort");

                foreach (ManagementObject queryObj in searcher.Get())
                {

                    if (queryObj != null)
                    {
                        object captionObj = queryObj["DESCRIPTION"];
                        object capdeviceid = queryObj["DEVICEID"];
                        object MaxBaudRate = queryObj["MAXBAUDRATE"];
                        object connstatus = queryObj["STATUS"];
                        string timeoutsec = "100";

                        dataGridView1.Rows.Add(capdeviceid, captionObj, MaxBaudRate, timeoutsec, connstatus);


                    }
                }

            }

            catch (Exception e15)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + e15.Message);
            }

            Cursor.Current = Cursors.Default;
            //button9.Enabled = false;
           // button10.Enabled = true;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!comm.IsConnected())
                {
                    MessageBox.Show("No Phone Connected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {

                    comm.Close();
                    pictureBox1.Image = imageList1.Images[0];
                    dataGridView1.Rows.Clear();
                    Phone_Model.Text = ".....";
                    Phone_Name.Text = ".....";
                    Revision_Num.Text = ".....";
                    Serial_Num.Text = ".....";
                    MessageBox.Show("Disconnected Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            catch (Exception No_Conn)
            {

                MessageBox.Show("No Phone Connected!!\r\n\n" + No_Conn, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }



        private void checkInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new FormCheckInOut();
            fm.Show();
            this.Hide();
        }

        private void adminLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin FormLogin = new FormLogin();
            FormLogin.Show();
        }

        /// <summary>
        /// PARA SA SINGLE MESSAGE
        /// </summary>
        private void Single_SMS_Click(object sender, EventArgs e)
        {
            string CELL_Number, SMS_Message;

            SmsSubmitPdu pdu1;


            try
            {

                if (comm.IsConnected() == true)
                {
                    if (Cell_Num.Text.ToString() == "")
                    {
                        MessageBox.Show("Kindly Add Cell Number\r\n\nFor Example\n\n+9231234567", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else if (SMS_Text.Text.ToString() == "")
                    {
                        MessageBox.Show("Kindly Add Your Message Text", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    CELL_Number = Cell_Num.Text.ToString();
                    SMS_Message = SMS_Text.Text.ToString();

                    MessageBox.Show("Kindly Re-Check Your SMS & CELL NUMBER \r\n\nCELL # : " + CELL_Number + "\r\n\nMESSAGE TEXT : " + SMS_Message, "SMS INFO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        pdu1 = new SmsSubmitPdu(SMS_Message, CELL_Number, "");

                        comm.SendMessage(pdu1);

                        Cursor.Current = Cursors.Default;

                        MessageBox.Show("M E S S A G E - S E N T", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    catch (Exception)
                    {

                        MessageBox.Show("Error Sending SMS To Destination Address\r\n\n Connection Has Been Terminated !!!\r\n\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comm.Close();
                        pictureBox1.Image = imageList1.Images[0];
                        Single_SMS.Enabled = false;
                        button4.Enabled = false;
                        button7.Enabled = false;
                        dataGridView1.Rows.Clear();
                        Phone_Model.Text = ".....";
                        Phone_Name.Text = ".....";
                        Revision_Num.Text = ".....";
                        Serial_Num.Text = ".....";

                    }


                }
                else
                {
                    MessageBox.Show("No GSM Phone / Modem Connected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("CONNECTION ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString() == "" ||
                            dataGridView1.Rows[i].Cells[j].Value.ToString().ToUpper() == "-" ||
                            dataGridView1.Rows[i].Cells[j].Value.ToString().Length > 160)

                        //Setting Cells Background color to RED if above Error Found in Any of the cells

                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;

                    //Setting Cells Background color to GREEN which passes above validations

                    else

                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Green;
                    button4.Enabled = true;


                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string MSMS_Number, MMessage;

            int i;

            SmsSubmitPdu pdu3;
            try
            {
                if (comm.IsConnected() == true)

                {

                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        for (i = 0; i < dataGridView2.RowCount - 1; i++)
                        {

                            MSMS_Number = dataGridView2.Rows[i].Cells[0].Value.ToString();
                            MMessage = dataGridView2.Rows[i].Cells[1].Value.ToString();


                            pdu3 = new SmsSubmitPdu(MMessage, MSMS_Number, "");

                            comm.SendMessage(pdu3);

                            //Sleeps system for 1000ms for refreshing GSM Modem

                            System.Threading.Thread.Sleep(1000);
                        }

                        Cursor.Current = Cursors.Default;

                        MessageBox.Show("T O T A L - M E S S A G E - S E N T = " + i, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Error Sending SMS To Destination Address\r\n\n Connection Has Been Terminated !!!\r\n\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comm.Close();
                        pictureBox1.Image = imageList1.Images[0];
                       // button9.Enabled = true;
                        //button10.Enabled = false;
                        //dataGridView1.Rows.Clear();
                        dataSet.Clear();
                        dataGridView1.Refresh();
                        button4.Enabled = false;
                        button7.Enabled = false;
                        Single_SMS.Enabled = false;
                        Phone_Model.Text = ".....";
                        Phone_Name.Text = ".....";
                        Revision_Num.Text = ".....";
                        Serial_Num.Text = ".....";

                    }
                }
                else
                {
                    MessageBox.Show("No GSM Phone / Modem Connected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button4.Enabled = false;
                    button7.Enabled = false;
                    return;
                }


            }
            catch (Exception)
            {

                label25.Text = "M U L T I P L E  -  S M S  -  I N F O";
                dataSet.Clear();
                dataGridView1.Refresh();
                button4.Enabled = false;
                button7.Enabled = false;
                MessageBox.Show("Error Sending SMS Messages\r\n\nKindly Check Connection\n\nNetwork Error Occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
            if (res == DialogResult.Cancel)
            {
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();

            style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            style.BackColor = Color.Green;
            style.ForeColor = Color.White;


            int i = dataGridView1.CurrentRow.Index;


            try
            {
                Comm_Port = Convert.ToInt16(dataGridView1.Rows[i].Cells[0].Value.ToString().Substring(3));
                Comm_BaudRate = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
                Comm_TimeOut = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Error Converting COM Port Settings Values", "Check COM Port Values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            comm = new GsmCommMain(Comm_Port, Comm_BaudRate, Comm_TimeOut);

            try
            {

                comm.Open();
                if (comm.IsConnected())
                {

                    pictureBox1.Image = imageList1.Images[1];

                    MessageBox.Show("Connected Successfully To GSM Phone / Modem...!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Rows[i].Cells[4].Value = "Connected";
                    dataGridView1.Rows[i].DefaultCellStyle = style;
                    dataGridView1.ClearSelection();
                    dataGridView1.Enabled = true;
                    // Form fm = new FormCheckInOut();
                    //fm.Show();
                    // this.Hide();
                }

                try
                {
                    Phone_Name.Text = comm.IdentifyDevice().Manufacturer.ToUpper().ToString();
                    Phone_Model.Text = comm.IdentifyDevice().Model.ToUpper().ToString();
                    Revision_Num.Text = comm.IdentifyDevice().Revision.ToUpper().ToString();
                    Serial_Num.Text = comm.IdentifyDevice().SerialNumber.ToUpper().ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Retriving COM Port Phone Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Error While Connecting To GSM Phone / Modem", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.ClearSelection();

            }
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOpenExcel_Click(object sender, EventArgs e)
        {
            int rows_counting, column_counting1 = 0;

            OpenFileDialog dialog = new OpenFileDialog { };

            dialog.Filter = "SMS Sending File(*.xlsx;*.xls)|*.xlsx;*.xls";

            dialog.Title = "Select Excel File For SMS";

            DialogResult dlgresult = dialog.ShowDialog();

            if (dlgresult == DialogResult.Cancel)
            {
                MessageBox.Show("You Press Cancelled :-) !!!");
            }
            else
            {
                string sms_filename = dialog.FileName;

                if (System.IO.File.Exists(sms_filename))
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", sms_filename);

                        string query = String.Format("select * from [{0}$]", "SMS");

                        OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connectionString);

                        dataSet = new DataSet();

                        dataAdapter.Fill(dataSet);

                        dataGridView2.DataSource = dataSet.Tables[0];

                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                        rows_counting = dataGridView2.RowCount - 1;

                        column_counting1 = dataGridView2.ColumnCount;

                        if (column_counting1 < 2 || column_counting1 > 2)
                        {
                            MessageBox.Show("Kindly Check Column Count in Excel Sheet !!!\r\n\nThere Should Be Only Two Columns in Sheet Like Below\r\n\nCELL NUMBER | MESSAGE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (dataGridView2.Columns[0].Name.ToString().ToUpper() == "CELL NUMBER" &&
                                dataGridView2.Columns[1].Name.ToString().ToUpper() == "MESSAGES")

                        {
                            label25.Text = "Total SMS In Excel File " + rows_counting;
                            MessageBox.Show("Data Imported Successfully...!!!\r\n\nCheck Imported Values & SEND SMS.....!!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button7.Enabled = true;
                            button4.Enabled = true;

                            Cursor.Current = Cursors.Default;
                        }
                        else
                        {
                            MessageBox.Show("Column Names Are Not In Specified Format !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error Loading Excel FIle\r\n\nKindly Check Worksheet Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
            }

        }
    }
}
