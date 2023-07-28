using System;


public class ArchiveRules
{
    private ArchiveData chatData;

    public ArchiveRules(ArchiveData data)
    {
        chatData = data;
    }

    public void ArchiveMessage(ArchiveModel message)
    {
        chatData.AddMessage(message);
    }
}