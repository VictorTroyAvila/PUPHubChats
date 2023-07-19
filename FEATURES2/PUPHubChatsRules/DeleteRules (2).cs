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
        // Step 1: Define a list of messages
        List<Message> messages = new List<Message>
        {
            new Message { Id = 1, Content = "Hello, World!" },
            new Message { Id = 2, Content = "This is a test message." },
            new Message { Id = 3, Content = "Goodbye!" }
        };

        // Step 2: Display available messages
        Console.WriteLine("Available Messages:");
        foreach (var message in messages)
        {
            Console.WriteLine($"ID: {message.Id}, Content: {message.Content}");
        }

        // Step 3: Prompt user for ID to delete
        Console.Write("Enter the ID of the message to delete: ");
        int messageIdToDelete;
        if (int.TryParse(Console.ReadLine(), out messageIdToDelete))
        {
            // Step 4: Find the message with the specified ID
            Message messageToDelete = messages.Find(m => m.Id == messageIdToDelete);
            if (messageToDelete != null)
            {
                // Step 5: Delete the message and display success message
                messages.Remove(messageToDelete);
                Console.WriteLine($"Message with ID {messageIdToDelete} deleted successfully.");
            }
            else
            {
                // Step 6: Display message not found
                Console.WriteLine($"Message with ID {messageIdToDelete} not found.");
            }
        }
        else
        {
            // Step 7: Display invalid input message
            Console.WriteLine("Invalid input. Please enter a valid numeric ID.");
        }
    }
}
