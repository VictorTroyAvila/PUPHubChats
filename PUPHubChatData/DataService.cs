using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUPHubChatsData
{
    public class DataService
    {

        public static bool verifyStudent(string search)
        {
            bool result = false;
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
                if (student == search)
                {
                    result = true;
                }
            }
            return result;
        }
        public static string MessageHistory(string MessageData)
        {
            List<string> msgHistory = new List<string>();

            msgHistory.Add(MessageData);

            return "Successfully Added";
        }
    }

    
}
