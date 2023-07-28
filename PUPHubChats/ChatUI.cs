using Data;
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
            
            MessageRules messageRules = new MessageRules();

            Console.WriteLine("Select Recipient");
                var search = Console.ReadLine().ToUpper();

                if (SearchService.SearchUser(search))
                {
                    Console.WriteLine("To: " + search);
                    Console.Write("Message: ");
                    Message = Console.ReadLine();
                    
                    messageRules.FormulateMessageData(search, Message);
                    Core.CoreUI();
                }
                else
                {
                    Console.WriteLine("User could not be found");
                    Core.CoreUI();
                }
}
        public static void ComposeToGroup()
        {
            MessageRules messageRules = new MessageRules();
            List<string> MessageHistory = new List<string>();
            String Message, choice, MessageData;
            Console.Write("Message: ");
            Message = Console.ReadLine();

            MessageData = messageRules.FormulateMessageData(Message);

            MessageHistory.Add(MessageData);
            GroupChatUI.GroupChat();
        }
    }
}
