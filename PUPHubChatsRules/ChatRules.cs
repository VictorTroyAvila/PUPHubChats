using System;
using System.IO;
using System.Collections.Generic;

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