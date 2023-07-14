class MessageRules
{
    public string ComposeMessage(string sender, string recipient, string subject, string body)
    {
        string message = $"From: {sender}\nTo: {recipient}\nSubject: {subject}\n\n{body}";
        return message;
    }
}