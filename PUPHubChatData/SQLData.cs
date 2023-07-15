using PUPHubChatData;
using PUPHubChatsModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace PUPHubChatsData
{
    public class SQLData
    {
        static string connectionString
            = "Data Source =localhost; Initial Catalog = DummyData; Integrated Security = True;";
        static SqlConnection sqlConnection;

        
        public SQLData()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public List<Students> addData()
        {
            var selectStatement = "SELECT LASTNAME, FIRSTNAME FROM  PUPHUBCHATS";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            var students = new List<Students>();

            while (reader.Read())
            {
                students.Add(new Students
                {
                    Lastname = reader["LASTNAME"].ToString(),
                    Firstname = reader["FIRSTNAME"].ToString()
                });
            }

            sqlConnection.Close();
            return students;
        }

        public List<Students> saveData()
        {
            var students = new List<Students>();
            return students;
        }

        public List<Students> removeData()
        {
            var students = new List<Students>();
            return students;
        }

    }
}
