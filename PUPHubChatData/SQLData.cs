using PUPHubChatsModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUPHubChatsData
{
    public class SQLData
    {
        static string connectionString
                = "Data Source = DESKTOP-TBGPD15\\MSSQLSERVER01; Initial Catalog = Testest; Integrated Security = True;";
            static SqlConnection sqlConnection;

            public SQLData()
            {
                sqlConnection = new SqlConnection(connectionString);
            }
            public List<Message> addData()
            {
                var selectStatement = "SELECT Name, Date, Message FROM  DummyData";
                SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();

                var students = new List<Message>();

                while (reader.Read())
                {
                    students.Add(new Message
                    {
                        name = reader["Name"].ToString(),
                        date = reader["Date"].ToString(),
                        message = reader["Date"].ToString()
                    });
                }

                sqlConnection.Close();
                return students;
            }

            public List<Message> showData()
            {
                var students = new List<Message>();
                return students;
            }

            public List<Message> removeData()
            {
                var students = new List<Message>();
                return students;
            }
        }
    }
