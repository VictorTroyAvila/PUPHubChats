using PUPHubChatsRules;
using PUPHubChatsData;
using static PUPHubChatsData.ChatsDataLayer;

public class Core
{
    public static void UserPrompt(char choice)
    {
        Console.WriteLine("You; ");
        ChatSystem cs = new ChatSystem(choice);

    }

    public static void ChatPrompt(int cs)
    {
        Console.WriteLine(InMemoryData.prof[cs] + ":");

    }
    public static String Spacer()
    {
        return "";
    }
    static void Main(String[] args)
    {
        char choice;

        Console.WriteLine("Welcome to the PUPHUB's ChatRoom");
        Console.WriteLine("How may I help you today");
        Console.WriteLine("[1] Chat with Prof");
        Console.WriteLine("[2] Access Database");
        Console.WriteLine("[X] Leave ChatRoom");
        //Model Choice
        choice = Console.ReadLine()[0];

        switch (choice)
        {
            case '1':
                Console.WriteLine("[1]Dr. Orozco");
                Console.WriteLine("[2]Mr. Almazan");
                Console.WriteLine("[3]Mr. Macha");
                Console.WriteLine("[4]Mr. Dela Cruz");
                Console.WriteLine("[5]Ms. Quinsayas");
                choice = Console.ReadLine()[0];

                Core.UserPrompt(choice);

                break;

             case '2':
                SQLData db = new SQLData();
                break;

            default:
                Console.WriteLine("Bye");
                break;

        }
    }
}