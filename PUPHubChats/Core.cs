using Features2;
using PUPHubChats;
public class Core
{
     static void Main(String[] args)
    {
        char choice;

        Console.WriteLine("Welcome to the PUPHUB's ChatRoom");
        Console.WriteLine("How may I help you today");
        Console.WriteLine("[1] Chat with Prof");
        Console.WriteLine("[2] Search Student");
        Console.WriteLine("[X] Leave ChatRoom");
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

                Chat ct = new Chat(choice);

                break;

            case '2':
                string input;

                Console.WriteLine("Enter Name: ");
                input = Console.ReadLine();
                SearchEngine search = new SearchEngine(input);
                break;

            default:
                Console.WriteLine("Bye");
                break;

        }
    }
}