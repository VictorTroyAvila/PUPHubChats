using System;
using System.Collections.Generic;
using System.IO;

public class PUPHubChatUnsend
{
    static void Main(string[] args)
    {
        UnsendModel unsendModel = GetUserInput();
        UnsendRules unsendRules = new UnsendRules();
        bool isMessageUnsent = unsendRules.CheckIfMessageUnsent(unsendModel.UserInput);

        if (isMessageUnsent)
        {
            DisplayUnsentMessage();
            DisplayChatMessage(unsendModel.MessageContent);

            UnsendData unsendData = new UnsendData();
            unsendData.AddMessage(unsendModel);
            unsendData.SaveToFile("unsent_messages.txt");
        }

        Console.ReadLine();
    }

    static UnsendModel GetUserInput()
    {
        Console.WriteLine("Enter your chat message: ");
        string chatMessage = Console.ReadLine();

        Console.WriteLine("Do you want to unsend the message? (yes/no): ");
        string userInput = Console.ReadLine().ToLower();

        return new UnsendModel(chatMessage, userInput);
    }

    static void DisplayUnsentMessage()
    {
        Console.WriteLine("You unsent a message.");
    }

    static void DisplayChatMessage(string chatMessage)
    {
        Console.WriteLine("Message You've Sent:");
        Console.WriteLine(chatMessage);
    }
}


