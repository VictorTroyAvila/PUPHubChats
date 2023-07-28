using System;


public class UnsendData
{
    private List<UnsendModel> messages = new List<UnsendModel>();

    public void AddMessage(UnsendModel message)
    {
        messages.Add(message);
    }

    public List<UnsendModel> GetAllMessages()
    {
        return messages;
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            foreach (var message in messages)
            {
                sw.WriteLine(message.MessageContent);
            }
        }
    }
}