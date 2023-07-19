using System;
using System.Collections.Generic;

class Message
{
    public int Id { get; set; }
    public string Content { get; set; }
}

class MessageDeleter
{
    static void Main()
    {
        List<Message> messages = new List<Message>
        {
            new Message { Id = 1, Content = "Hello, World!" },
            new Message { Id = 2, Content = "This is a test message." },
            new Message { Id = 3, Content = "Goodbye!" }
        };

        Console.WriteLine("Available Messages:");
        foreach (var message in messages)
        {
            Console.WriteLine($"ID: {message.Id}, Content: {message.Content}");
        }

        Console.Write("Enter the ID of the message to delete: ");
        int messageIdToDelete;
        if (int.TryParse(Console.ReadLine(), out messageIdToDelete))
        {
            Message messageToDelete = messages.Find(m => m.Id == messageIdToDelete);
            if (messageToDelete != null)
            {
                messages.Remove(messageToDelete);
                Console.WriteLine($"Message with ID {messageIdToDelete} deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Message with ID {messageIdToDelete} not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric ID.");
        }
    }
}
