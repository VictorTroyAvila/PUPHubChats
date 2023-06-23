using System;

class ChatSystem
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the chat!");

        bool chatEnabled = true;

        while (true)
        {
            Console.Write("Enter your message: ");
            string message = Console.ReadLine();

            if (chatEnabled)
            {
                Console.WriteLine("Message sent: " + message);
            }
            else
            {
                Console.WriteLine("Chat is currently disabled. Your message cannot be sent.");
            }

            Console.WriteLine();

            if (message.ToLower() == "disable")
            {
                chatEnabled = false;
                Console.WriteLine("Chat disabled.");
            }
            else if (message.ToLower() == "enable")
            {
                chatEnabled = true;
                Console.WriteLine("Chat enabled.");
            }
            else if (message.ToLower() == "exit")
            {
                break;
            }
        }

        Console.WriteLine("Chat session ended.");
    }
}
