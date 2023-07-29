using Data;
using System;
using System.Collections.Generic;
using System.IO;

public class PUPHubChatUnsend
{
    
    public static void Unsend()
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
        SQLDataMessageStatus sQLMStatus = new SQLDataMessageStatus();
        Console.WriteLine("Enter Message ");
        string chatMessage = Console.ReadLine();
        Console.WriteLine("Do you want to unsend the message? (yes/no): ");
        string userInput = Console.ReadLine().ToLower();

        if (userInput == "yes")
        {
            string usend = "Unsent";
            sQLMStatus.EditUnsendMessage(usend);
        }
        else
        {
            string usend = "Sent";
            sQLMStatus.EditUnsendMessage(usend);
        }

        return new UnsendModel(chatMessage, userInput);
    }

    static void DisplayUnsentMessage()
    {
        Console.WriteLine("You unsent a message.");
        Core.CoreUI();
    }

    static void DisplayChatMessage(string chatMessage)
    {
        Console.WriteLine("Message You've Sent:");
        Console.WriteLine(chatMessage);
        Core.CoreUI();
    }
}


