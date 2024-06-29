using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LUBANG_ATTENDANCE.FormAdmin
{
    public partial class FormAddHoliday : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=lubang_db;SslMode=none");
        DataTable holidaysTable; // DataTable to store holidays data

        public FormAddHoliday()
        {
            InitializeComponent();
            textBoxHolidayName = new System.Windows.Forms.TextBox();
            dateTimePickerHolidayDate = new System.Windows.Forms.DateTimePicker();
            holidaysTable = new DataTable();
    
        }

        private void FormAddHoliday_Load(object sender, EventArgs e)
        {
            // Load existing holidays data when the form loads
            LoadHolidaysData();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void LoadHolidaysData()
        {
           
                try
            {
                // Fetch holidays data from the database
                string query = "SELECT holiday_date, holiday_name FROM holidays";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                holidaysTable.Clear(); // Clear existing data
                adapter.Fill(holidaysTable);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = holidaysTable;

                // Add a delete button column to the DataGridView
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "Delete";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(deleteButtonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading holidays: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddHoliday_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from controls
                DateTime holidayDate = dateTimePickerHolidayDate.Value;
                string holidayName = textBoxHolidayName.Text;

                // Insert into the holidays table
                string query = "INSERT INTO holidays (holiday_date, holiday_name) VALUES (@holidayDate, @holidayName)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@holidayDate", holidayDate);
                cmd.Parameters.AddWithValue("@holidayName", holidayName);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Holiday added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload the holidays data and refresh the DataGridView
                LoadHolidaysData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            
                {
                // Get the value in the selected row's holiday_name column
                string holidayNameToDelete = dataGridView1.Rows[e.RowIndex].Cells["holiday_name"].Value.ToString();

                // Call a method to delete the selected holiday
                DeleteHoliday(holidayNameToDelete);
            }
        }

        private void DeleteHoliday(string holidayNameToDelete)
        {
            try
            {
                // Delete the holiday from the database
                string query = "DELETE FROM holidays WHERE holiday_name = @holidayName";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@holidayName", holidayNameToDelete);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Holiday deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload the holidays data and refresh the DataGridView
                LoadHolidaysData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}