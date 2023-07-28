using System;
using System.Collections.Generic;
using System.Xml.Linq;


public class FollowBackUI
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
                    Console.Write("Enter the username to follow: ");
                    string username = Console.ReadLine();
                    rules.FollowUser(username);
                    break;
                case 2:
                    List<string> followers = rules.GetFollowers();
                    Console.WriteLine("Followers:");
                    foreach (var follower in followers)
                    {
                        Console.WriteLine(follower);
                    }
                    break;
                case 3:
                    List<string> following = rules.GetFollowing();
                    Console.WriteLine("Following:");
                    foreach (var user in following)
                    {
                        Console.WriteLine(user);
                    }
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

    public static void Follow()
    {
        FollowBackUI followBackUI = new FollowBackUI();
        followBackUI.Run();
    }
}
