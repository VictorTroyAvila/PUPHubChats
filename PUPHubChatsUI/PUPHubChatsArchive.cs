class Message
{
    public string Content { get; set; }
}

class PUPHubChatsArchive
{
    private static void Main()
    {
        Console.WriteLine("Chat Archiving Program");

        Console.Write("Enter the name of the person: ");
        string personName = Console.ReadLine();

        string fileName = $"{personName}_chat";

        try
        {
            ChatData chatData = new ChatData();
            ChatRules chatRules = new ChatRules(chatData);

            Console.WriteLine($"Chat with {personName} (Type 'exit' to stop archiving):\n");

            while (true)
            {
                string message = Console.ReadLine();

                if (message.ToLower() == "exit")
                {
                    break;
                }

                chatRules.ArchiveMessage(new Message { Content = message });
            }

            chatData.SaveToFile(fileName);
            Console.WriteLine($"Chat with {personName} has been archived successfully in {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

internal class ChatRules
{
    private ChatData chatData;

    public ChatRules(ChatData chatData)
    {
        this.chatData = chatData;
    }

    internal void ArchiveMessage(Message message)
    {
        throw new NotImplementedException();
    }
}

internal class ChatData
{
    internal void SaveToFile(string fileName)
    {
        throw new NotImplementedException();
    }
}