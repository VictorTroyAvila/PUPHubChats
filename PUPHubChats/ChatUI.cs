using PUPHubChatsRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class ChatUI
    {
        public static void Compose()
        {
            String Message, choice, MessageData;
            List<string> MessageHistory = new List<string>();
            MessageRules messageRules = new MessageRules();

            Console.WriteLine("Select Recipients");
                var search = Console.ReadLine().ToUpper();

                if (messageRules.DoesExist(search))
                {
                    Console.WriteLine("To: " + search);
                    Console.Write("Message: ");
                    Message = Console.ReadLine();

                    MessageData = messageRules.FormulateMessageData(search, Message);

                    MessageHistory.Add(MessageData);
                    //sQLData.addData();

                }
                else
                {
                    Console.WriteLine("Hindi na hanap");
                }
}
    }
}
