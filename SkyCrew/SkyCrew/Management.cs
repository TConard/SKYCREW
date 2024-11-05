using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkyCrew
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
            LoadData();
            // Initialize buttons and other components here
            this.btnOpenPilotForm.Click += new System.EventHandler(this.btnOpenPilotForm_Click);
            this.btnOpenGroundCrewForm.Click += new System.EventHandler(this.btnOpenGroundCrewForm_Click);
            this.btnOpenCustomerServiceForm.Click += new System.EventHandler(this.btnOpenCustomerServiceForm_Click);
            this.btnOpenAdminForm.Click += new System.EventHandler(this.btnOpenAdminForm_Click);
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.ConnectToDatabase())
                {
                    // Load staff data into dataGridViewStaff (Users table with role filter)
                    LoadDataIntoGridView(conn, "SELECT * FROM Users WHERE Role IN ('Pilot', 'Ground Crew', 'Customer Service', 'Admin')", dataGridViewStaff);

                    // Load flight data into dataGridViewFlights
                    LoadDataIntoGridView(conn, "SELECT * FROM Flights", dataGridViewFlights);

                    // Load booking data into dataGridViewBookings
                    LoadDataIntoGridView(conn, "SELECT * FROM Bookings", dataGridViewBookings);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataIntoGridView(SqlConnection conn, string query, DataGridView gridView)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridView.DataSource = dataTable;
        }

        private void btnOpenPilotForm_Click(object sender, EventArgs e)
        {
            // Open the Pilot form
            Pilot pilotForm = new Pilot();
            pilotForm.Show();
        }

        private void btnOpenGroundCrewForm_Click(object sender, EventArgs e)
        {
            // Open the Ground Crew form
            GroundCrew groundCrewForm = new GroundCrew();
            groundCrewForm.Show();
        }

        private void btnOpenCustomerServiceForm_Click(object sender, EventArgs e)
        {
            // Open the Customer Service form
            CustomerService customerServiceForm = new CustomerService();
            customerServiceForm.Show();
        }

        private void btnOpenAdminForm_Click(object sender, EventArgs e)
        {
            // Open the Admin form
            Admin adminForm = new Admin();
            adminForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }
    }
}
