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
using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
namespace LUBANG_ATTENDANCE.FormReport
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=lubang_db;SslMode=none");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        string sql;
        private void FormReport_Load(object sender, EventArgs e)
        {
            LoadDataRecord();
        }
        public void LoadDataRecord()
        {
            try
            {
                sql = "SELECT CONCAT(LASTNAME,', ',FIRSTNAME,' ',MI) AS NAME, YEARLEVEL, SECTION, CONTACT, LOGDATE, TIMEIN AS ARRIVAL, TIMEOUT AS DEPARTURE, ATTENDACE_STATUS AS STATUS FROM table_logged LEFT JOIN table_student ON table_logged.QRCODE = table_student.QRCODE ORDER BY LOGDATE DESC";
                loadData(sql);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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

                dataGridView1.DataSource = dt;
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

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
   
            sql = "SELECT CONCAT(LASTNAME,', ',FIRSTNAME,' ',MI) AS NAME, YEARLEVEL, SECTION, CONTACT, LOGDATE, TIMEIN AS ARRIVAL, TIMEOUT AS DEPARTURE, ATTENDACE_STATUS AS STATUS FROM table_logged LEFT JOIN table_student ON table_logged.QRCODE = table_student.QRCODE WHERE FIRSTNAME LIKE'%" + this.textBoxSearch.Text + "%' OR LASTNAME LIKE'%" + this.textBoxSearch.Text + "%' ORDER BY LOGDATE DESC";
            loadData(sql);
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
        
            sql = "SELECT CONCAT(LASTNAME,', ',FIRSTNAME,' ',MI) AS NAME, YEARLEVEL, SECTION, CONTACT, LOGDATE, TIMEIN AS ARRIVAL, TIMEOUT AS DEPARTURE, ATTENDACE_STATUS AS STATUS FROM table_logged LEFT JOIN table_student ON table_logged.QRCODE = table_student.QRCODE WHERE DATE(`LOGDATE`) =CURDATE() ORDER BY LOGDATE DESC";
            loadData(sql);

        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            sql = "SELECT CONCAT(LASTNAME,', ',FIRSTNAME,' ',MI) AS NAME, YEARLEVEL, SECTION, CONTACT, LOGDATE, TIMEIN AS ARRIVAL, TIMEOUT AS DEPARTURE, ATTENDACE_STATUS AS STATUS FROM table_logged LEFT JOIN table_student ON table_logged.QRCODE = table_student.QRCODE WHERE WEEK(`LOGDATE`) =WEEK(NOW()) ORDER BY LOGDATE DESC";
            loadData(sql);
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            sql = "SELECT CONCAT(LASTNAME,', ',FIRSTNAME,' ',MI) AS NAME, YEARLEVEL, SECTION, CONTACT, LOGDATE, TIMEIN AS ARRIVAL, TIMEOUT AS DEPARTURE, ATTENDACE_STATUS AS STATUS FROM table_logged LEFT JOIN table_student ON table_logged.QRCODE = table_student.QRCODE WHERE MONTH(`LOGDATE`) =MONTH(NOW()) ORDER BY LOGDATE DESC";
            loadData(sql);
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            LoadDataRecord();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            StudentRecord();
        }
        public void StudentRecord()
        {
            try
            {
     
                sql = "SELECT CONCAT(LASTNAME,', ',FIRSTNAME,' ',MI) AS NAME, AGE, GENDER,DOB, YEARLEVEL, SECTION, CONTACT FROM table_student";
                loadData(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            int i;
            int j;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlApp.Visible = true;
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Sheets["sheet1"];
           

            // FOR HEADERS
            for (i = 1; i <= dataGridView1.ColumnCount; i++)
            {
                xlWorkSheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                
                // FOR ITEMS
                for (j = 1; j <= dataGridView1.RowCount; j++)
                  xlWorkSheet.Cells[j + 1, i] = dataGridView1[i - 1, j - 1].Value;


            }
        }
        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)

            {

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (*.pdf)|*.pdf";

                save.FileName = "Result.pdf";

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)

                {

                    if (File.Exists(save.FileName))

                    {

                        try

                        {

                            File.Delete(save.FileName);

                        }

                        catch (Exception ex)

                        {

                            ErrorMessage = true;

                            MessageBox.Show("Unable to wride data in disk" + ex.Message);

                        }

                    }

                    if (!ErrorMessage)

                    {

                        try

                        {

                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView1.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in dataGridView1.Rows)

                            {

                                foreach (DataGridViewCell dcell in viewRow.Cells)

                                {

                                    pTable.AddCell(dcell.Value.ToString());

                                }

                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                            {

                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();

                                document.Add(pTable);

                                document.Close();

                                fileStream.Close();

                            }

                            MessageBox.Show("Data Export Successfully", "info");

                        }

                        catch (Exception ex)

                        {

                            MessageBox.Show("Error while exporting Data" + ex.Message);

                        }

                    }

                }

            }

            else

            {

                MessageBox.Show("No Record Found", "Info");

            }
        }
    }
}
