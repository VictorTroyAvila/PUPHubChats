using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Chat Archiving Program");

        Console.Write("Enter the name of the person: ");
        string personName = Console.ReadLine();

        ChatArchiver chatArchiver = new ChatArchiver(personName);
        chatArchiver.ArchiveChat();

    }
}