using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkyCrew
{
    public partial class GroundCrew : Form
    {
        public GroundCrew()
        {
            InitializeComponent();
            LoadFlightSchedule();
            monthCalendar1.DateSelected += MonthCalendar1_DateSelected;
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

                    dataGridViewShifts.DataSource = flightTable;
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

                    dataGridViewShifts.DataSource = flightTable;

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

        private void buttonAcceptShift_Click(object sender, EventArgs e)
        {
            if (dataGridViewShifts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a shift to accept.", "No Shift Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedFlightNumber = dataGridViewShifts.SelectedRows[0].Cells["FlightNumber"].Value.ToString();

            try
            {
                using (SqlConnection conn = DatabaseConnection.ConnectToDatabase())
                {
                    conn.Open();
                    string updateQuery = "UPDATE Flights SET Status = 'Accepted' WHERE FlightNumber = @FlightNumber";
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@FlightNumber", selectedFlightNumber);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Shift accepted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFlightsForDate(monthCalendar1.SelectionStart); // Refresh for the selected date
                    }
                    else
                    {
                        MessageBox.Show("Failed to accept the shift.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accepting shift: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelShift_Click(object sender, EventArgs e)
        {
            if (dataGridViewShifts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a shift to drop.", "No Shift Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedFlightNumber = dataGridViewShifts.SelectedRows[0].Cells["FlightNumber"].Value.ToString();
            string selectedStatus = dataGridViewShifts.SelectedRows[0].Cells["Status"].Value.ToString();

            // Confirm that only "Accepted" shifts can be dropped
            if (!string.Equals(selectedStatus, "Accepted", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Only accepted shifts can be dropped.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.ConnectToDatabase())
                {
                    conn.Open();
                    string updateQuery = "UPDATE Flights SET Status = 'Scheduled' WHERE FlightNumber = @FlightNumber";
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@FlightNumber", selectedFlightNumber);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Shift dropped successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFlightsForDate(monthCalendar1.SelectionStart); // Refresh for the selected date
                    }
                    else
                    {
                        MessageBox.Show("Failed to drop the shift. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
