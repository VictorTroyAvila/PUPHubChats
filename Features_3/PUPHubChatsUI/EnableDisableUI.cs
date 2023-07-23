using System;
using System.Collections.Generic;
class EnableDisableUI

{
    static void Main(string[] args)
    {
        EnableDisableUI.WriteLine("Welcome to the chat!");

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
}

class ChatSession
{
    private bool chatEnabled = true;

    public void Start()
    {
        EnableDisableData chatData = new EnableDisableData();
        EnableDisableRules chatRules = new EnableDisableRules();

        while (true)
        {
            string message = EnableDisableUI.ReadInput("Enter your message: ");

            if (chatEnabled)
            {
                chatData.SendMessage(message);
            }
            else
            {
                EnableDisableUI.WriteLine("Chat is currently disabled. Your message cannot be sent.");
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