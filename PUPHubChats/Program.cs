using System.Collections;
internal class program {

    public static void Main (String[] args) {
    String chat1;
    String chat2;
    char choice;

    Console.WriteLine("Welcome to the PUPHUB's ChatRoom");
    Console.WriteLine("How may I help you today");
    Console.WriteLine("[1] Chat with Prof");
    Console.WriteLine("[2] Chat with Student");
    Console.WriteLine("[X] Leave ChatRoom");
    choice = Console.ReadLine()[0];

    switch (choice)
    {
        case '1':
                List <String> prof = new List<String>{"Dr.Orozco","Mr.Almazan","Mr.Macha","Mr.Dela Cruz","Ms.Quinsayas"};
                Console.WriteLine("[1]Dr. Orozco");
                Console.WriteLine("[2]Mr. Almazan");
                Console.WriteLine("[3]Mr. Macha");
                Console.WriteLine("[4]Mr. Dela Cruz");
                Console.WriteLine("[5]Ms. Quinsayas");
                choice = Console.ReadLine()[0];

                switch (choice)
                {
                    case '1':
                        Console.WriteLine("Type 'Thank You' to exit chat");
                        do
                        {
                            Console.WriteLine("You:");
                            chat1 = Console.ReadLine();
                            Console.WriteLine();

                            Console.WriteLine(prof[0] + ":");
                            chat2 = Console.ReadLine();
                            Console.WriteLine();
                        }
                        while (chat1 != "Thank You");
                        break;
                    case '2':
                        Console.WriteLine("Type 'Thank You' to exit chat");
                        do
                        {
                            Console.WriteLine("You:");
                            chat1 = Console.ReadLine();
                            Console.WriteLine();

                            Console.WriteLine(prof[1] + ":");
                            chat2 = Console.ReadLine();
                            Console.WriteLine();
                        }
                        while (chat1 != "Thank You");
                        break;
                    case '3':
                        Console.WriteLine("Type 'Thank You' to exit chat");
                        do
                        {
                            Console.WriteLine("You:");
                            chat1 = Console.ReadLine();
                            Console.WriteLine();

                            Console.WriteLine(prof[2] + ":");
                            chat2 = Console.ReadLine();
                            Console.WriteLine();
                        }
                        while (chat1 != "Thank You");
                        break;
                    case '4':
                        Console.WriteLine("Type 'Thank You' to exit chat");
                        do
                        {
                            Console.WriteLine("You:");
                            chat1 = Console.ReadLine();
                            Console.WriteLine();

                            Console.WriteLine(prof[3] + ":");
                            chat2 = Console.ReadLine();
                            Console.WriteLine();
                        }
                        while (chat1 != "Thank You");
                        break;
                    case '5':
                        Console.WriteLine("Type 'Thank You' to exit chat");
                        do
                        {
                            Console.WriteLine("You:");
                            chat1 = Console.ReadLine();
                            Console.WriteLine();

                            Console.WriteLine(prof[4] + ":");
                            chat2 = Console.ReadLine();
                            Console.WriteLine();
                        }
                        while (chat1 != "Thank You");
                        break;
                }

                break;

        case '2':
            Console.WriteLine("2");
            break;

        default: 
            Console.WriteLine("Bye");
            break;

    }
}   
}