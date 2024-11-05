using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkyCrew
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string role = comboBoxRole.SelectedItem?.ToString();

            // Check if inputs are valid
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please enter your email, password, and select a role.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve the connection string from App.config
            string connectionString = ConfigurationManager.ConnectionStrings["LNBAirlines"].ConnectionString;

            // Query to check if the user exists with the provided email, password, and role
            string query = "SELECT Role FROM Users WHERE Email = @Email AND Password = @Password AND Role = @Role";

            // Using block to ensure the connection is closed automatically
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null) // If the user exists, result will not be null
                    {
                        // Open the appropriate dashboard based on the role
                        if (role == "Pilot")
                        {
                            Pilot pilotForm = new Pilot();
                            pilotForm.Show();
                        }
                        else if (role == "Ground Crew")
                        {
                            GroundCrew groundCrewForm = new GroundCrew();
                            groundCrewForm.Show();
                        }
                        else if (role == "Customer Service")
                        {
                            CustomerService customerServiceForm = new CustomerService();
                            customerServiceForm.Show();
                        }
                        else if (role == "Admin")
                        {
                            Admin adminForm = new Admin();
                            adminForm.Show();
                        }
                        else if (role == "Management")
                        {
                            Management managementForm = new Management();
                            managementForm.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email, password, or role. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for the exit button
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closes the entire application
        }
    }
}
