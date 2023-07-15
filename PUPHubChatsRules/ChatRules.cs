using static PUPHubChatsData.ChatsDataLayer;

namespace PUPHubChatsRules
{
    public class ChatSystem
    {
        public ChatSystem(char choice)
        {
            String chat1;
            String chat2;
            
            do
            {
                chat1 = Console.ReadLine();
                //Spacing
                
                Console.WriteLine();
                if (chat1 == "Chat Close")
                {
                    break;
                }

                //ChatPrompt
                Console.WriteLine(InMemoryData.prof[ChatSystem.SelectedChoice(choice)] + ":");
                chat2 = Console.ReadLine();
                Console.WriteLine();
                if (chat2 == "Chat Close")
                {
                    break;
                }
            }
            while (chat1 != "Chat Close");
        }

        internal static int SelectedChoice(char choice)
        {
            int cs = choice - '1';
            return cs;
        }
    }
        
}
