List<Message> messages = new List<Message>
        {
            new Message { Id = 1, Content = "Hello, World!" },
            new Message { Id = 2, Content = "This is a test message." },
            new Message { Id = 3, Content = "Goodbye!" }
        };

// Step 2: Display available messages
foreach (var message in messages)
{

}

// Step 3: Prompt user for ID to delete

int messageIdToDelete;
if (int.TryParse(Console.ReadLine(), out messageIdToDelete))
{
    // Step 4: Find the message with the specified ID
    Message messageToDelete = messages.Find(m => m.Id == messageIdToDelete);
    if (messageToDelete != null)
    {
        // Step 5: Delete the message and display success message
        messages.Remove(messageToDelete);

    }
    else
    {
        // Step 6: Display message not found

    }
}
else
{
    // Step 7: Display invalid input message

}
