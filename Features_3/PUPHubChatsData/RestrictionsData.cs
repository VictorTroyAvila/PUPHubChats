using System;
using System.Collections.Generic;

class RestrictionsData
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Message sent: " + message);
    }
}
class ChatController
{
    private RestrictionsData chatData;
    private RestrictionRules chatRules;

    public ChatController(string userType)
    {
        chatData = new RestrictionsData();
        chatRules = new RestrictionRules(userType);
    }

    public void StartChat()
    {
        while (true)
        {
            Console.Write("Enter your message: ");
            string message = Console.ReadLine();

            bool isRestricted = chatRules.CheckRestrictedWords(message);

            if (isRestricted)
            {
                Console.WriteLine("Your message cannot be sent as it contains restricted words.");
            }
            else
            {
                chatData.SendMessage(message);
            }

            Console.WriteLine();

            if (message.ToLower() == "exit")
            {
                break;
            }
        }
    }
}