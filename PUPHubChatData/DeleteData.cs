using System;

public class DeleteData
{
    private List<DeleteModel> messages = new List<DeleteModel>
    {
        new DeleteModel { Id = 1, Content = "Hello, World!" },
        new DeleteModel { Id = 2, Content = "This is a test message." },
        new DeleteModel { Id = 3, Content = "Goodbye!" }
    };

    public List<DeleteModel> GetAllMessages()
    {
        return messages;
    }

    public void RemoveMessage(DeleteModel message)
    {
        messages.Remove(message);
    }
}

