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
        }

        private void LoadFlightSchedule()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LNBAirlines"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT FlightNumber, DepartureTime, ArrivalTime, Status FROM Flights"; // Adjusted columns as needed
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable flightTable = new DataTable();
                    adapter.Fill(flightTable);

                    dataGridViewFlights.DataSource = flightTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading flight schedule: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
