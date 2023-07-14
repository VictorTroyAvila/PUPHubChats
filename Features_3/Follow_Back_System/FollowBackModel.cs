public class FollowBackModel
{
    private FollowBackRules rules = new FollowBackRules();

    public void Run()
    {
        Console.WriteLine("Welcome to the Follow-Back System!");

        while (true)
        {
            Console.WriteLine("1. Follow");
            Console.WriteLine("2. Show Followers");
            Console.WriteLine("3. Show Following");
            Console.WriteLine("4. Exit");
            Console.Write("\nEnter your choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    rules.FollowUser();
                    break;
                case 2:
                    rules.ShowFollowers();
                    break;
                case 3:
                    rules.ShowFollowing();
                    break;
                case 4:
                    Console.WriteLine("Exiting the program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
}