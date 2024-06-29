using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace LUBANG_ATTENDANCE
{
    public partial class FormCalendar : Form
    {
        private List<DateTime> holidays = new List<DateTime>();
        private MySqlConnection connection;

        public FormCalendar()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            // Set your MySQL connection string
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=lubang_db;SslMode=none");

            connection = con;
        }

        private void SaveDataToDatabase()
        {
            try
            {
                connection.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Get values from the DataGridView
                    DateTime date = DateTime.Parse(row.Cells["Date"].Value.ToString());
                    string description = row.Cells["Description"].Value.ToString();

                    // Create a MySQL command to insert data
                    string query = "INSERT INTO table_calendar (Date, Description) VALUES (@Date, @Description)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Description", description);

                        // Execute the MySQL command
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data saved to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveDataToDatabase();
        }

        private void FormCalendar_Load(object sender, EventArgs e)
        {
             // Initialize the DataGridView
            InitializeDataGridView();

            // Load holidays from the database or any other source
            LoadHolidays();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns["Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
            dataGridView1.Columns["Date"].ReadOnly = true;
            dataGridView1.Columns.Add("Description", "Description");
        }
        private void tb_Holiday_TextChanged(object sender, EventArgs e)
        {
            // Your event handler code here
        }

        private void LoadHolidays()
        {
            // Load holidays from the database or any other source
            // For demonstration purposes, let's add some sample holidays
            holidays.Add(new DateTime(DateTime.Now.Year, 1, 1)); // New Year's Day
            holidays.Add(new DateTime(DateTime.Now.Year, 6, 12)); // Independence Day

            // Display holidays in the DataGridView
            foreach (var holiday in holidays)
            {
                dataGridView1.Rows.Add(holiday.ToString("yyyy-MM-dd"), "Holiday");
                HighlightDate(holiday, Color.Red);
            }
        }

        private void DatePK_ValueChanged(object sender, EventArgs e)
        {
            // Optional: You can add logic here if needed when the DateTimePicker value changes.
        }

        private void add_button_holiday_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DatePK.Value;
            string description = tb_Holiday.Text;

            // Check if the date is already added as a holiday
            if (!holidays.Contains(selectedDate))
            {
                // Add the holiday to the list
                holidays.Add(selectedDate);

                // Add the holiday to the DataGridView
                dataGridView1.Rows.Add(selectedDate.ToString("yyyy-MM-dd"), description);

                // Add the holiday to the ListView
                ListViewItem listViewItem = new ListViewItem(selectedDate.ToString("yyyy-MM-dd"));
                listViewItem.SubItems.Add(description);
                listView1.Items.Add(listViewItem);

                // Highlight the selected date in the Calendar
                HighlightDate(selectedDate, Color.Red);
            }
            else
            {
                MessageBox.Show("Date is already added as a holiday.", "Duplicate Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Clear the input fields
            DatePK.Value = DateTime.Now;
            tb_Holiday.Clear();
        }

        private void HighlightDate(DateTime date, Color highlightColor)
        {
           /* monthCalendar1.AddAnnuallyBoldedDate(date);
            monthCalendar1.UpdateBoldedDates();
            monthCalendar1.Update();
            monthCalendar1.Refresh();
            monthCalendar1.SetSelectionRange(date, date);
            monthCalendar1.SelectionRange = new SelectionRange(); // Deselect the date
            monthCalendar1.Update();
            monthCalendar1.Refresh();*/
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Optional: You can add logic here if needed when the selected date in the calendar changes.
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Optional: You can add logic here if needed when an item is selected in the ListView.
        }
    }
}