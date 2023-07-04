using System;

class ChatSession
{
    private bool chatEnabled = true;

    public void Start()
    {
        Console.WriteLine("Welcome to the chat!");

        ChatModels user= new ChatModels();
        ChatData chatData = new ChatData();
        ChatRules chatRules = new ChatRules();

        while (true)
        {
            string message = user.GetMessage();

            if (chatEnabled)
            {
                chatData.SendMessage(message);
            }
            else
            {
                Console.WriteLine("Chat is currently disabled. Your message cannot be sent.");
            }

            Console.WriteLine();

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

        Console.WriteLine("Chat session ended.");
    }

    private void DisableChat()
    {
        chatEnabled = false;
        Console.WriteLine("Chat disabled.");
    }

    private void EnableChat()
    {
        chatEnabled = true;
        Console.WriteLine("Chat enabled.");
    }
}