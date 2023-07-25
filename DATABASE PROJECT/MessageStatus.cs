using System;
using System.Data;
using System.Data.SqlClient;

public class MessageStatusDb
{
    private string connectionString = "Data Source=LAPTOP-7JIIS4KE\\SQLEXPRESS;Initial Catalog=USERSTATUS;Integrated Security=True;";

    // Method to add a message reaction to the MessageReactions column in the database
    public void AddMessageReaction(string reaction)
    {
        AddMessageStatus("MessageReactions", reaction);
    }

    // Method to add an unsend message status to the UnsendMessage column in the database
    public void AddUnsendMessageStatus(string status)
    {
        AddMessageStatus("UnsendMessage", status);
    }

    // Method to add a search messages or members status to the SearchMessagesOrMembers column in the database
    public void AddSearchMessagesOrMembersStatus(string status)
    {
        AddMessageStatus("SearchMessagesOrMembers", status);
    }

    // Method to add a group chat status to the GroupChat column in the database
    public void AddGroupChatStatus(string status)
    {
        AddMessageStatus("GroupChat", status);
    }

    // Generic method to add a message status to the specified column in the database
    private void AddMessageStatus(string columnName, string status)
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
                            string messageReactions = reader["MessageReactions"].ToString();
                            string unsendMessage = reader["UnsendMessage"].ToString();
                            string searchMessagesOrMembers = reader["SearchMessagesOrMembers"].ToString();
                            string groupChat = reader["GroupChat"].ToString();

                            // Do something with the retrieved data (e.g., display, process, etc.)
                            Console.WriteLine($"MessageReactions: {messageReactions}, UnsendMessage: {unsendMessage}, SearchMessagesOrMembers: {searchMessagesOrMembers}, GroupChat: {groupChat}");
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
