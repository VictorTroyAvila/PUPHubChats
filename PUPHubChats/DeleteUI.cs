using System;
public class DeleteUI
{
    public static void Main()
    {
        DeleteData data = new DeleteData();
        List<DeleteModel> messages = data.GetAllMessages();

        Console.WriteLine("Available Messages:");
        foreach (var message in messages)
        {
            Console.WriteLine($"ID: {message.Id}, Content: {message.Content}");
        }

        Console.Write("Enter the ID of the message to delete: ");
        if (int.TryParse(Console.ReadLine(), out int messageIdToDelete))
        {
            DeleteRules rules = new DeleteRules();
            DeleteModel messageToDelete = rules.FindMessageById(messages, messageIdToDelete);

            if (messageToDelete != null)
            {
                data.RemoveMessage(messageToDelete);
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