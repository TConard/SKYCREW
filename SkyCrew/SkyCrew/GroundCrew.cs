using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyCrew
{
    public partial class GroundCrew : Form
    {
        public GroundCrew()
        {
            InitializeComponent();
            LoadAvailableShifts();
        }

        private void groupUpcomingShifts_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxUser_Click(object sender, EventArgs e)
        {

        }

        private void groupShiftTrends_Enter(object sender, EventArgs e)
        {

        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoadAvailableShifts()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LNBAirlines"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT FlightID, FlightNumber, DepartureTime FROM Flights WHERE Status = 'Scheduled'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable shiftsTable = new DataTable();
                    adapter.Fill(shiftsTable);

                    dataGridViewShifts.DataSource = shiftsTable;

                    // Hide the FlightID column for display purposes
                    if (dataGridViewShifts.Columns["FlightID"] != null)
                        dataGridViewShifts.Columns["FlightID"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading shifts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close(); // Ensure the connection is closed
                }
            }
        }





        private void buttonAcceptShift_Click(object sender, EventArgs e)
        {
            // Ensure a shift is selected
            if (dataGridViewShifts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a shift to accept.", "No Shift Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve the selected shift's FlightID from the hidden column
            int selectedFlightID = Convert.ToInt32(dataGridViewShifts.SelectedRows[0].Cells["FlightID"].Value);

            try
            {
                using (SqlConnection conn = DatabaseConnection.ConnectToDatabase())
                {
                    conn.Open(); // Open the connection at the beginning

                    // Update query to mark the shift as accepted
                    string updateQuery = "UPDATE Flights SET Status = 'Accepted' WHERE FlightID = @FlightID";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FlightID", selectedFlightID);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Shift accepted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAvailableShifts(); // Refresh shifts to remove accepted ones
                        }
                        else
                        {
                            MessageBox.Show("Failed to accept the shift. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                } // The connection will automatically close here due to the `using` statement
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
