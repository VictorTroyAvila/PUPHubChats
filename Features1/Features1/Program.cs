using System;

class PUPHubChatsUnsent
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your chat message: ");
        string chatMessage = Console.ReadLine();

        bool isMessageSent = false;

        Console.WriteLine("Do you Want to unsent the message? (yes/no): ");
        string userInput = Console.ReadLine().ToLower();

        if (userInput == "yes")
        {
            Console.WriteLine("You Unsent a Message");
            isMessageSent = true;
        }
        else if (userInput == "no")
        {
            Console.WriteLine("Message Has Been Sent");
            isMessageSent = true;
        }
        else
        {
            Console.WriteLine("Invalid input. Please try again.");
        }

        if (isMessageSent)
        {
            Console.WriteLine("Message You've Unsent:");
            Console.WriteLine(chatMessage);
        }

        Console.ReadLine();
    }
}
