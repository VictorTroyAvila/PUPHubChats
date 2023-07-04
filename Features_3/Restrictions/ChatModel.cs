class ChatModel
{
    public void Run()
    {
        Console.WriteLine("Welcome to the chat!");

        Console.Write("Are you a professor or a student? ");
        string userType = Console.ReadLine();

        bool isProfessor = (userType.ToLower() == "professor");

        ChatController chatController = new ChatController(isProfessor);
        chatController.StartChat();

        Console.WriteLine("Chat session ended.");
    }
}

