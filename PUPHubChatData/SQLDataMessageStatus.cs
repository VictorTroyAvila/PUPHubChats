using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class SQLDataMessageStatus
    {
        private string connectionString = "Data Source=DESKTOP-TBGPD15\\MSSQLSERVER01;Initial Catalog=Testest;Integrated Security=True;";
        //"Server=tcp:4.193.106.92,1433;Database=PUPHubPoints;User Id = sa; Password=PUPHUB123!;"
        // Method to add a message reaction to the MessageReactions column in the database
        public void EditMessageReaction(string reaction)
        {
            EditMessageStatus("MessageReactions", reaction);
        }
        // Method to add data to the MessageData column in the database
        public void EditMessageData(string msgData)
        {
            EditMessageStatus("MessageData", msgData);
        }
        // Method to add a Date and Time to the DateNTime column in the database
        public void EditUnsendMessage(string umessage)
        {
            EditMessageStatus("UnsendMessage", umessage);
        }
        // Method to add an archived message status to the ArchivedMessage column in the database
        public void EditArchiveMessage(string amessage)
        {
            EditMessageStatus("ArchivedMessage", amessage);
        }
        // Generic method to add a message status to the specified column in the database
        private void EditMessageStatus(string columnName, string status)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Add the message status to the specified column in the database
                    string query = $"INSERT INTO MessageStatuss ({columnName}) VALUES (@Status)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", status);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during the database connection or query execution
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        //Generic method to update a message status to the specified column in the database
        private void UpdateMessageStatus(string columnName, string status)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Add the message status to the specified column in the database
                    string query = $"UPDATE MessageStatuss SET ({columnName}) WHERE (@Status)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", status);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during the database connection or query execution
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        // Method to retrieve data from the MessageStatuss table - Same as before (to display the current status)
        public void DisplayMessageStatus()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Perform the SELECT query
                    string query = "SELECT * FROM MessageStatuss";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Assuming your table has columns: MessageReactions, UnsendMessage, etc.
                                string username = reader["UserName"].ToString();
                                string dateandtime = reader["DatNTime"].ToString();
                                string message = reader["ComposedMessage"].ToString();
                                string messageReactions = reader["MessageReactions"].ToString();
                                string umessage = reader["UnsendMessage"].ToString();
                                string amessage = reader["ArchivedMessage"].ToString();

                                // Do something with the retrieved data (e.g., display, process, etc.)
                                Console.WriteLine($"UserName: {username}, Date and Time: {dateandtime}\n Message: {message}, Reactions: {messageReactions}, Unsent: {umessage}, Archived: {amessage}, ");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during the database connection or query execution
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

    }
}
