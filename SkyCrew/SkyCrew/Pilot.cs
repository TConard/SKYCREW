using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkyCrew
{
    public partial class Pilot : Form
    {
        public Pilot()
        {
            InitializeComponent();
            LoadFlightSchedule();
            monthCalendar1.DateSelected += MonthCalendar1_DateSelected;
            btnRequestLeave.Click += BtnRequestLeave_Click; // Bind the button click event
        }

        private void LoadFlightSchedule()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LNBAirlines"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT FlightNumber, DepartureTime, ArrivalTime, Status FROM Flights";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable flightTable = new DataTable();
                    adapter.Fill(flightTable);

                    dataGridViewFlights.DataSource = flightTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading flight schedule: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start; // The date user clicked
            LoadFlightsForDate(selectedDate);
        }

        private void LoadFlightsForDate(DateTime date)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LNBAirlines"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT FlightNumber, DepartureTime, ArrivalTime, Status 
                        FROM Flights 
                        WHERE CAST(DepartureTime AS DATE) = @SelectedDate";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SelectedDate", date);
                    DataTable flightTable = new DataTable();
                    adapter.Fill(flightTable);

                    dataGridViewFlights.DataSource = flightTable;

                    if (flightTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No flights scheduled for the selected date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading flights for date: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRequestLeave_Click(object sender, EventArgs e)
        {
            // Ensure a flight is selected
            if (dataGridViewFlights.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a flight to request leave.", "No Flight Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve the selected flight's FlightNumber
            string selectedFlightNumber = dataGridViewFlights.SelectedRows[0].Cells["FlightNumber"].Value.ToString();

            try
            {
                using (SqlConnection conn = DatabaseConnection.ConnectToDatabase())
                {
                    conn.Open();
                    string updateQuery = "UPDATE Flights SET Status = 'PTO' WHERE FlightNumber = @FlightNumber";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FlightNumber", selectedFlightNumber);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Leave requested successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadFlightsForDate(monthCalendar1.SelectionStart); // Refresh for the selected date
                        }
                        else
                        {
                            MessageBox.Show("Failed to request leave. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
