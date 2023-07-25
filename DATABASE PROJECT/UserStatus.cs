using System;
using System.Data;
using System.Data.SqlClient;

public class UserStatusDb
{
    private string connectionString = "Data Source=LAPTOP-7JIIS4KE\\SQLEXPRESS;Initial Catalog=USERSTATUS;Integrated Security=True;";

    // Method to add a member to the BlockMember column in the database
    public void BlockMember(string memberName)
    {
        AddMemberToColumn("BlockMember", memberName);
    }

    // Method to add a member to the MutedMember column in the database
    public void MuteMember(string memberName)
    {
        AddMemberToColumn("MutedMember", memberName);
    }

    // Method to add a member to the ArchivedMember column in the database
    public void ArchiveMember(string memberName)
    {
        AddMemberToColumn("ArchivedMember", memberName);
    }

    // Method to add a member to the ComposedNewMessage column in the database
    public void ComposeNewMessage(string memberName)
    {
        AddMemberToColumn("ComposedNewMessage", memberName);
    }

    // Method to add a member to the AttachFiles column in the database
    public void AttachFiles(string memberName)
    {
        AddMemberToColumn("AttachFiles", memberName);
    }

    // Method to add a member to the DeleteConvo column in the database
    public void DeleteConvo(string memberName)
    {
        AddMemberToColumn("DeleteConvo", memberName);
    }

    // Method to add a member to the RestrictedMember column in the database
    public void RestrictMember(string memberName)
    {
        AddMemberToColumn("RestrictedMember", memberName);
    }

    // Method to add a member to the FollowersAndFollowings column in the database
    public void AddFollowerAndFollowing(string memberName)
    {
        AddMemberToColumn("FollowersAndFollowings", memberName);
    }

    // Generic method to add a member to the specified column in the database
    private void AddMemberToColumn(string columnName, string memberName)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Add the member to the specified column in the database
                string query = $"INSERT INTO UserStatuss ({columnName}) VALUES (@MemberName)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberName", memberName);
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

    // Method to retrieve data from the UserStatuss table - Same as before (to display the current status)
    public void DisplayUserStatus()
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Perform the SELECT query
                string query = "SELECT * FROM UserStatuss";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming your table has columns: BlockMember, MutedMember, etc.
                            string blockMember = reader["BlockMember"].ToString();
                            string mutedMember = reader["MutedMember"].ToString();
                            string archivedMember = reader["ArchivedMember"].ToString();
                            string composedNewMessage = reader["ComposedNewMessage"].ToString();
                            string attachFiles = reader["AttachFiles"].ToString();
                            string deleteConvo = reader["DeleteConvo"].ToString();
                            string restrictedMember = reader["RestrictedMember"].ToString();
                            string followersAndFollowings = reader["FollowersAndFollowings"].ToString();

                            // Do something with the retrieved data (e.g., display, process, etc.)
                            Console.WriteLine($"BlockMember: {blockMember}, MutedMember: {mutedMember}, ArchivedMember: {archivedMember}, ComposedNewMessage: {composedNewMessage}, AttachFiles: {attachFiles}, DeleteConvo: {deleteConvo}, RestrictedMember: {restrictedMember}, FollowersAndFollowings: {followersAndFollowings}");
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
