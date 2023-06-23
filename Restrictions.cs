using System;

class ChatRestriction
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the chat!");

        bool isRestricted = false;
        string[] restrictedWords = { "bad words", "inappropriate", "offensive" };

        while (true)
        {
            Console.Write("Enter your message: ");
            string message = Console.ReadLine();

            if (isRestricted)
            {
                Console.WriteLine("Your message cannot be sent as it contains restricted words.");
            }
            else
            {
                foreach (string word in restrictedWords)
                {
                    if (message.ToLower().Contains(word.ToLower()))
                    {
                        isRestricted = true;
                        break;
                    }
                }

                if (isRestricted)
                {
                    Console.WriteLine("Your message cannot be sent as it contains restricted words.");
                }
                else
                {
                    Console.WriteLine("Message sent: " + message);
                }
            }

            Console.WriteLine();

            if (message.ToLower() == "exit")
            {
                break;
            }
        }

        Console.WriteLine("Chat session ended.");
    }
}