using System.ComponentModel;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using PUPHubChatsData;
using PUPHubChatsRules;

public class Core
{
    static void Main(String[] args)
    {
        String Message, choice,  MessageData;
        List<string> MessageHistory = new List<string>();
        MessageRules messageRules = new MessageRules();
        
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

                //Rules
                
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

                goto SelectAction;

            case "2":
                for (int i = 0; i < MessageHistory.Count; i++)
                {
                    Console.WriteLine(MessageHistory[i]);
                }
                //sQLData.showData();
                goto SelectAction;

            case "3":
                Console.WriteLine("Under Construction");

                break;
                //Reaction feature
        }
    }
}
