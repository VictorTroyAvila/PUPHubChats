using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class SQLDataUserStatus
    {
        private string connectionString = "Data Source=YUKI;Initial Catalog=dev;Integrated Security=True;";

        // Method to add a member to the BlockMember column in the database
        public void BlockMember(string memberName)
        {
            AddMemberToColumn("BlockMember", memberName);
        }

        // Method to add a member to the MutedMember column in the database
        public void MuteMember(string memberName, string mute)
        {
            AddMemberToColumn("MutedMember", memberName);
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

        // Method to add a member to the Followers column in the database
        public void AddFollower(string newfollower)
        {
            AddMemberToColumn("FollowersAndFollowings", newfollower);
        }
        // Method to add a member to the Followings column in the database
        public void AddFollowings(string newfollowings)
        {
            AddMemberToColumn("Followings", newfollowings);
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
                                string members = reader["Members"].ToString();
                                string blockMember = reader["BlockMember"].ToString();
                                string mutedMember = reader["MutedMember"].ToString();
                                string deleteConvo = reader["DeleteConvo"].ToString();
                                string restrictedMember = reader["RestrictedMember"].ToString();
                                string followers = reader["Followers"].ToString();
                                string followings = reader["Followings"].ToString();

                                // Do something with the retrieved data (e.g., display, process, etc.)
                                Console.WriteLine($"Member: {members}, BlockMember: {blockMember}, MutedMember: {mutedMember}, DeleteConvo: {deleteConvo}, RestrictedMember: {restrictedMember}, Followers: {followers}, Followings: {followings}");
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
