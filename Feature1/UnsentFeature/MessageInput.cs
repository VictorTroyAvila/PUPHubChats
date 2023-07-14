using System;
using System.Collections.Generic;

namespace Feature1
{
    class MessageInput
    {
        public string ChatMessage { get; }
        public string UserInput { get; }

        public MessageInput(string chatMessage, string userInput)
        {
            ChatMessage = chatMessage;
            UserInput = userInput;
        }
    }
}