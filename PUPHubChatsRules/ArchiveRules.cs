using Data;
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
        SQLDataMessageStatus sQLMStatus = new SQLDataMessageStatus();
        sQLMStatus.EditArchiveMessage(message.ToString());
    }
}