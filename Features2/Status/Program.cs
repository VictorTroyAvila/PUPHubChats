using System;

class PUPHubChatsStatus
{
    static void Main(string[] args)
    {
        Console.WriteLine("What Status are you in? (online/exam/marketplace/offline): ");
        string userInput = Console.ReadLine().ToLower();

        bool isOnline = userInput == "online";
        bool isTakingAnExam = userInput == "exam";
        bool isInMarketPlace = userInput == "marketplace";
        bool isOffline = userInput == "offline";

        if (isOnline)
        {
            Console.WriteLine("You are currently Online.");
        }
        if (isTakingAnExam)
        {
            Console.WriteLine("You are currently taking an Examination.");
        }
        if (isInMarketPlace)
        {
            Console.WriteLine("You are currently visiting the MarketPlace.");
        }
        if (isOffline)
        {

            Console.WriteLine("You are Currently Offline.");
        }

        Console.ReadLine();
    }
}