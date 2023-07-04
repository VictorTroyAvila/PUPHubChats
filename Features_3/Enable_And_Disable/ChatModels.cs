class ChatModels
{
    private string userType = "";

    public string GetUserType()
    {
        Console.Write("Are you a student or a professor? (Enter 'student' or 'professor'): ");
        return Console.ReadLine().ToLower();
    }

    public string GetMessage()
    {
        if (string.IsNullOrEmpty(userType))
        {
            userType = GetUserType();
            if (userType != "student" && userType != "professor")
            {
                Console.WriteLine("Invalid user type. Please try again.");
                return GetMessage();
            }
        }

        Console.Write("Enter your message: ");
        return Console.ReadLine();
    }
}