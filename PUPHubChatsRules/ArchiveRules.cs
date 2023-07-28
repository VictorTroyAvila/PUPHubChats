using System;


public class ArchiveRules
{
    private ChatData chatData;

    public ArchiveRules(ChatData data)
    {
        chatData = data;
    }

    public void ArchiveMessage(Message message)
    {
        chatData.AddMessage(message);
    }
}