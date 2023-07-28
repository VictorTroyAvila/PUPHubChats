using System;
using PUPHubChatsData;
using System.Collections.Generic;

public class RestrictionUI
{
    public static void Restrict()
    {
        RestrictionUI chatUI = new RestrictionUI();
        chatUI.StartChat();
    }

    private RestrictionsData chatData;
    private RestrictionRules chatRules;
    private string userType;

    public RestrictionUI()
    {
        chatData = new RestrictionsData();
        userType = GetUserType();
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

    private string GetUserType()
    {
        Console.Write("Are you a student or a professor? (Enter 'student' or 'professor'): ");
        string input = Console.ReadLine().ToLower();

        if (input != "student" && input != "professor")
        {
            Console.WriteLine("Invalid user type. Please try again.");
            return GetUserType();
        }

        return input;
    }
}