using System;

public class ChatArchiver
{
    private readonly string fileName;

    public ChatArchiver(string personName)
    {
        fileName = $"{personName}_chat";
    }

    public void ArchiveChat()
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                Console.WriteLine($"Chat with {fileName.Split('_')[0]} (Type 'exit' to stop archiving):\n");

                while (true)
                {
                    string message = Console.ReadLine();

                    if (message.ToLower() == "exit")
                    {
                        break;
                    }

                    sw.WriteLine($"{message}");
                }
            }

            Console.WriteLine($"Chat with {fileName.Split('_')[0]} has been archived successfully in {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    public void ViewArchivedChat()
    {
        try
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                Console.WriteLine($"Archived Chat with {fileName.Split('_')[0]}:\n");

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while viewing the archived chat: {ex.Message}");
        }
    }
}