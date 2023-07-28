using System;


public class PUPHubChatsArchive
{
    public static void Archive()
    {
        Console.WriteLine("Chat Archiving Program");

        Console.Write("Enter the name of the person: ");
        string personName = Console.ReadLine();

        string fileName = $"{personName}_chat";

        try
        {
            ArchiveData chatData = new ArchiveData();
            ArchiveRules chatRules = new ArchiveRules (chatData);

            Console.WriteLine($"Chat with {personName} (Type 'exit' to stop archiving):\n");

            while (true)
            {
                string message = Console.ReadLine();

                if (message.ToLower() == "exit")
                {
                    break;
                }

                chatRules.ArchiveMessage(new ArchiveModel { Content = message });
            }

            chatData.SaveToFile(fileName);
            Console.WriteLine($"Chat with {personName} has been archived successfully in {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}