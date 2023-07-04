class ChatController
{
    private ChatData chatData;
    private ChatRules chatRules;

    public ChatController(bool isProfessor)
    {
        chatData = new ChatData();
        chatRules = new ChatRules(isProfessor);
    }

    public void StartChat()
    {
        while (true)
        {
            Console.Write("Enter your message: ");
            string message = Console.ReadLine();

            bool isRestricted = chatRules.CheckRestrictedWords(message);

            if (isRestricted)
            {
                Console.WriteLine("Your message cannot be sent as it contains restricted words.");
            }
            else
            {
                chatData.SendMessage(message);
            }

            Console.WriteLine();

            if (message.ToLower() == "exit")
            {
                break;
            }
        }
    }
}