using System;

public class UnsendModel
{
    public string MessageContent { get; }
    public string UserInput { get; }

    public UnsendModel(string messageContent, string userInput)
    {
        MessageContent = messageContent;
        UserInput = userInput;
    }
}
