class MessageComposer
{
    static void Main()
    {
        string sender = "pastorjemen@gmail.com";
        string recipient = "jcremolacio@gmail.com";
        string subject = "Tara valo ";
        string body = ("valovalo ");

        string composedMessage = ComposeMessage(sender, recipient, subject, body);

    }

    static string ComposeMessage(string sender, string recipient, string subject, string body)
    {
        string message = $"From: {sender}\nTo: {recipient}\nSubject: {subject}\n\n{body}";
        return message;
    }
}