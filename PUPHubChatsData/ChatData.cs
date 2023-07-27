using System;
using System.IO;
using System.Collections.Generic;

class ChatData
{
    private List<Message> messages = new List<Message>();

    public void AddMessage(Message message)
    {
        messages.Add(message);
    }

    public List<Message> GetAllMessages()
    {
        return messages;
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            foreach (var message in messages)
            {
                sw.WriteLine(message.Content);
            }
        }
    }
}
