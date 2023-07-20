using System;

public class ChatMessage
{
    public string Sender { get; set; }
    public string Message { get; set; }

    public ChatMessage(string sender, string message)
    {
        Sender = sender;
        Message = message;
    }

    public override string ToString()
    {
        return $"{Sender}: {Message}";
    }
}