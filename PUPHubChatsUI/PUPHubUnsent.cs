class PUPHubUnsent
{
    static void Main(string[] args)
    {
        MessageInput messageInput = GetUserInput();
        MessageRules messageRules = new MessageRules();
        bool isMessageSent = messageRules.CheckIfMessageSent(messageInput.UserInput);

        if (!isMessageSent)
        {
            DisplayUnsentMessage();
            DisplayChatMessage(messageInput.ChatMessage);
        }

        Console.ReadLine();
    }

    static MessageInput GetUserInput()
    {
        Console.WriteLine("Enter your chat message: ");
        string chatMessage = Console.ReadLine();

        Console.WriteLine("Do you want to unsend the message? (yes/no): ");
        string userInput = Console.ReadLine().ToLower();

        return new MessageInput(chatMessage, userInput);
    }

    static void DisplayUnsentMessage()
    {
        Console.WriteLine("You unsent a message.");
    }

    static void DisplayChatMessage(string chatMessage)
    {
        Console.WriteLine("Message You've Sent:");
        Console.WriteLine(chatMessage);
    }
}

internal class MessageRules
{
    internal bool CheckIfMessageSent(object userInput)
    {
        throw new NotImplementedException();
    }
}

internal class MessageInput
{
    public MessageInput(string? chatMessage, string userInput)
    {
        ChatMessage = chatMessage;
        UserInput = userInput;
    }

    public object UserInput { get; internal set; }
    public string ChatMessage { get; internal set; }
}