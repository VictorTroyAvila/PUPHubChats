using System;

class PUPHubChatsStatus
{
    static void Main(string[] args)
    {
        Console.WriteLine("What Status are you in? (online/taking an examination/is in marketplace/is playing/is studying/offline): ");
        string userInput = Console.ReadLine().ToLower();

        StatusData statusData = new StatusData();
        StatusRules statusRules = new StatusRules();

        string statusMessage = statusRules.GetStatusMessage(userInput, statusData);
        DisplayStatusMessage(statusMessage);

        Console.ReadLine();
    }

    static void DisplayStatusMessage(string message)
    {
        Console.WriteLine(message);
    }
}