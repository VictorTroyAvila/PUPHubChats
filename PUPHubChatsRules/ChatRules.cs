﻿using PUPHubChats;
using PUPHubChatsModels;
using System.Runtime.CompilerServices;
using static PUPHubChatData.ChatDataLayer;

namespace PUPHubChats
{
    public class ChatSystem
    {
        public ChatSystem(char choice)
        {
            String chat1;
            String chat2;
            int i = choice - '1';
                        
            do
            {
                Console.WriteLine("You:");
                chat1 = Console.ReadLine();
                Console.WriteLine();
                if (chat1 == "Chat Close")
                {
                    break;
                }

                Console.WriteLine(InMemoryData.prof[i] + ":");
                chat2 = Console.ReadLine();
                Console.WriteLine();
                if (chat2 == "Chat Close")
                {
                    break;
                }
            }
            while (chat1 != "Chat Close");
        }
    }
}
