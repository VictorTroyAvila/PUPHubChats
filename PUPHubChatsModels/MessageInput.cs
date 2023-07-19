using System;
using System.Collections.Generic;

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