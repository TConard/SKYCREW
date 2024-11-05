using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyCrew
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (comboBoxReportType.SelectedItem == null)
            {
                MessageBox.Show("Please select a report type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedReport = comboBoxReportType.SelectedItem.ToString();

            try
            {
                using (SqlConnection conn = DatabaseConnection.ConnectToDatabase())
                {
                    string reportQuery = "";

                    // Determine the report type and set the appropriate query
                    switch (selectedReport)
                    {
                        case "Flight Report":
                            reportQuery = @"
                        SELECT 
                            FlightNumber, 
                            DepartureTime, 
                            ArrivalTime, 
                            Status,
                            (SELECT COUNT(*) FROM Bookings WHERE Bookings.FlightID = Flights.FlightID) AS TotalBookings
                        FROM Flights
                        ORDER BY DepartureTime";
                            break;

                        case "Staff Report":
                            reportQuery = @"
                        SELECT 
                            FirstName, 
                            LastName, 
                            Role, 
                            Email, 
                            HireDate
                        FROM Users
                        WHERE Role != 'Customer'
                        ORDER BY Role, HireDate";
                            break;

                        case "Bookings Report":
                            reportQuery = @"
                        SELECT 
                            BookingID, 
                            FlightID, 
                            PassengerID, 
                            BookingDate, 
                            SeatNumber, 
                            TicketPrice
                        FROM Bookings
                        ORDER BY BookingDate DESC";
                            break;

                        default:
                            MessageBox.Show("Invalid report type selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    // Execute the query and populate the DataGridView
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(reportQuery, conn);
                    DataTable reportTable = new DataTable();
                    dataAdapter.Fill(reportTable);

                    dataGridViewReport.DataSource = reportTable;

                    if (reportTable.Rows.Count > 0)
                    {
                        MessageBox.Show($"{selectedReport} generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No data found for the selected report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the Admin form
        }

    }
}
