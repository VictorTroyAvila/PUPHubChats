using System;
using System.Collections.Generic;

public class EnableDisableUI
{
    public static void EnD()
    {
        WriteLine("Welcome to the chat!");

        ChatSession chatSession = new ChatSession();
        chatSession.Start();
    }

    public static void WriteLine(string message = "")
    {
        Console.WriteLine(message);
    }

    public static void Write(string message)
    {
        Console.Write(message);
    }

    public static string ReadInput(string message)
    {
        Write(message);
        return Console.ReadLine();
    }

    public static bool IsStatusCommand(string message)
    {
        return message.ToLower() == "enable" || message.ToLower() == "disable";
    }

    public static void ShowStatus(string status)
    {
        WriteLine("User status: " + status);
    }
}

class ChatSession
{
    private bool chatEnabled = true;
    private bool userActive = true;

    public void Start()
    {
        EnableDisableData chatData = new EnableDisableData();
        EnableDisableRules chatRules = new EnableDisableRules();

        while (true)
        {
            string message = EnableDisableUI.ReadInput("Enter your message: ");

            if (EnableDisableUI.IsStatusCommand(message))
            {
                if (message.ToLower() == "enable")
                {
                    userActive = true;
                }
                else if (message.ToLower() == "disable")
                {
                    userActive = false;
                }
                else
                {
                    EnableDisableUI.WriteLine("Invalid status command.");
                }
                EnableDisableUI.ShowStatus(userActive ? "Active" : "Inactive");
                continue;
            }

            if (chatEnabled && userActive)
            {
                chatData.SendMessage(message);
            }
            else
            {
                EnableDisableUI.WriteLine("Chat is currently disabled or you are inactive. Your message cannot be sent.");
            }

            EnableDisableUI.WriteLine();

            if (chatRules.ShouldDisableChat(message))
            {
                DisableChat();
            }
            else if (chatRules.ShouldEnableChat(message))
            {
                EnableChat();
            }
            else if (chatRules.ShouldExit(message))
            {
                break;
            }
        }

        EnableDisableUI.WriteLine("Chat session ended.");
        Core.CoreUI();
    }

    private void DisableChat()
    {
        chatEnabled = false;
        EnableDisableUI.WriteLine("Chat disabled.");
    }

    private void EnableChat()
    {
        chatEnabled = true;
        EnableDisableUI.WriteLine("Chat enabled.");
    }
}