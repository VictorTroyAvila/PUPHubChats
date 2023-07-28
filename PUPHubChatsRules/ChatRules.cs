class ChatRules
{
    private ChatData chatData;

    public ChatRules(ChatData data)
    {
        chatData = data;
    }

    public void ArchiveMessage(Message message)
    {
        chatData.AddMessage(message);
    }
}

public class Message
{
}

internal class ChatData
{
    internal void AddMessage(Message message)
    {
        throw new NotImplementedException();
    }
}