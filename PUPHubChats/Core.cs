using System.ComponentModel;
using System.Data.SqlClient;

public class Core
{
    static void Main(String[] args)
    {
        String Message, choice,  MessageData;
        List<string> MessageHistory = new List<string>();
        DateTime currentDateTime = DateTime.Now;
        SQLData sQLData = new SQLData();
        
        Console.WriteLine("Press anything to continue");
        Console.ReadLine();

    SelectAction:
        Console.WriteLine("Select action");
        Console.WriteLine("[1] Compose Message");
        Console.WriteLine("[2] View Messages");
        Console.WriteLine("[3] React to Message");
        Console.WriteLine("[4] Unsend Message");
        Console.WriteLine("[X] Exit");
        choice = Console.ReadLine();

        switch (choice)
        {
            case "1":

                Console.WriteLine("Select Recipients");
                var search = Console.ReadLine().ToUpper();
                if (Core.DoesExist(search))
                {
                    // Dito papasok yung SearchEngine
                    // connect sa database hahanapin yung pangalan
                    // Follow and unfollow feature kung papayagan ichat

                    Console.WriteLine("To: " + search);
                    Console.Write("Message: ");
                    Message = Console.ReadLine();

                    MessageData = search + "\n" + currentDateTime + "\n" + Message + "\n";

                    //Connect to db to save message there (Conyo namp)
                    //so alternative muna toh

                    MessageHistory.Add(MessageData);

                    //tas balik sa select action
                }
                else
                {
                    Console.WriteLine("Hindi na hanap");
                }

                goto SelectAction;

            case "2":
                for (int i = 0; i < MessageHistory.Count; i++)
                {
                    Console.WriteLine(MessageHistory[i]);
                }
                goto SelectAction;

            case "3":
                Console.WriteLine("Under Construction");
                break;
                //Reaction feature
        }
    }
    public static bool DoesExist(string search)
    {
        bool result=false;
        var Students = new List<string>()
        {
            "VICTOR TROY AVILA",
            "MARIA YUKI VILLANUEVA",
            "REGINA FELIX LOPEZ",
            "JEMEN PASTOR",
            "JOHN CHRISTOPHER REMOLACIO",
            "DHUKE MARQUEZ"
        };
        foreach (var student in Students) 
        {
            if(student == search) 
            {
                result = true;
            }
        }
        return result;
}
        public class SQLData
    {
        static string connectionString
            = "Data Source =DESKTOP-TBGPD15\\MSSQLSERVER01; Initial Catalog = Testest; Integrated Security = True;";
        static SqlConnection sqlConnection;

        public SQLData()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public List<Students> addData()
        {
            var selectStatement = "SELECT Lastname, Firstname FROM  DummyData";
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
        public class Students
        {
        public string Firstname { get; set;}
        public string Lastname { get; set;}
        }
}