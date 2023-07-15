using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUPHubChatsData
{
    public class DBase
    {
        static string connectionString
            = "Data Source =localhost; Initial Catalog = DummyData; Integrated Security = True;";
        static SqlConnection sqlConnection;
    }
}
