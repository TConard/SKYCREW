using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SkyCrew
{
    public static class DatabaseConnection
    {
        public static SqlConnection ConnectToDatabase()
        {
            // List of connection strings for each developer
            List<string> connectionStrings = new List<string>
            {
                "Data Source=TREYSPC\\SQLEXPRESS;Initial Catalog=LNBAirlines;Integrated Security=True;"
                
                // Add additional connection strings as needed
            };

            SqlConnection connection = null;

            foreach (var connectionString in connectionStrings)
            {
                try
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open(); // Try to open a connection
                    break; // Exit the loop if successful
                }
                catch
                {
                    // Suppress exception for individual connection attempts
                    connection?.Dispose(); // Clean up failed connection object
                    connection = null; // Reset connection for the next attempt
                }
            }

            if (connection == null)
            {
                throw new Exception("Unable to connect to any database.");
            }

            return connection; // Return the successful connection
        }
    }
}
