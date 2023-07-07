using System;

class PUPHubChatsStatus
{
    static void Main(string[] args)
    {
        Console.WriteLine("What Status are you in? (online/taking an examination/is in marketplace/is playing/is studying): ");
        string userInput = Console.ReadLine().ToLower();

        bool isOnline = userInput == "online";
        bool isTakingAnExam = userInput == "examination";
        bool isInMarketPlace = userInput == "marketplace";
        bool isPlaying = userInput == "playing";
        bool isStudying = userInput == "study";
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
        if (isPlaying)
        {
            Console.WriteLine("You are currently playing");
        }
        if (isStudying)
        {
            Console.WriteLine("You are currently studying");
        }
        if (isOffline)
        {
            Console.WriteLine("You are currently Offline");
        }
        else
        {

            Console.WriteLine("Thankyou for Answering!.");
        }

        Console.ReadLine();
    }
}
