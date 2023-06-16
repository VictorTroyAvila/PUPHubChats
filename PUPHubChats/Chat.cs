using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PUPHubChats;

namespace PUPHubChats
{
    public class Chat
    {
        public Chat(char choice) 
        {
            String chat1;
            String chat2;
            int i = choice - '1';
            List<String> prof = new List<String> { "Dr.Orozco", "Mr.Almazan", "Mr.Macha", "Mr.Dela Cruz", "Ms.Quinsayas" };

            do
            {
                Console.WriteLine("You:");
                chat1 = Console.ReadLine();
                Console.WriteLine();
                if (chat1 == "Chat Close")
                {
                    break;
                }
                
                Console.WriteLine(prof[i] + ":");
                chat2 = Console.ReadLine();
                Console.WriteLine();
                if (chat2 == "Chat Close")
                {
                    break;
                }
            }
            while (chat1 != "Chat Close");
        }
    }
}
