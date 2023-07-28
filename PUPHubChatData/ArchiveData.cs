using System;

public class ArchiveData
{
    private List<ArchiveModel> messages = new List<ArchiveModel>();

    public void AddMessage(ArchiveModel message)
    {
        messages.Add(message);
    }

    public List<ArchiveModel> GetAllMessages()
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
