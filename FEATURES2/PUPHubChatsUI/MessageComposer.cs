using System;

class MessageComposer
{
    static void Main()
    {
        MessageData messageData = new MessageData();

        string sender = messageData.Sender;
        string recipient = messageData.Recipient;
        string subject = messageData.Subject;
        string body = messageData.Body;

        MessageRules messageRules = new MessageRules();
        string composedMessage = messageRules.ComposeMessage(sender, recipient, subject, body);

        Console.WriteLine(composedMessage);
    }
}