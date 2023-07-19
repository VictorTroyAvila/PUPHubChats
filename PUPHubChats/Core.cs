using System.ComponentModel;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using PUPHubChatsData;
using PUPHubChatsRules;
using PUPHubChatsModels;

public class Core
{
    static void Main(String[] args)
    {
        String Message, choice,  MessageData;


        List<string> MessageHistory = new List<string>();
<<<<<<< Updated upstream
        MessageRules messageRules = new MessageRules();
=======
        
        DateTime currentDateTime = DateTime.Now;
        
        //Data
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
                
                //Data
                if (Core.DoesExist(search))
                {
                    // Dito papasok yung SearchEngine
                    // connect sa database hahanapin yung pangalan
                    // Follow and unfollow feature kung papayagan ichat
>>>>>>> Stashed changes

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
                goto SelectAction;

            case "3":
                Console.WriteLine("Under Construction");

                break;
                //Reaction feature
        }
    }
}
