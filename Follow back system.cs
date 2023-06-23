using System;
using System.Collections.Generic;

class FollowBackSystem
{
    static Dictionary<string, List<string>> followers = new Dictionary<string, List<string>>();

    static void Main(string[] args)
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
                    FollowUser();
                    break;
                case 2:
                    ShowFollowers();
                    break;
                case 3:
                    ShowFollowing();
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

    static void FollowUser()
    {
        Console.Write("\nEnter your username: ");
        string username = Console.ReadLine();
        if (string.IsNullOrEmpty(username))
        {
            Console.WriteLine("Invalid username. Please enter a valid username.");
            return;
        }

        Console.Write("Enter the username of the user you want to follow: ");
        string followUsername = Console.ReadLine();
        if (string.IsNullOrEmpty(followUsername))
        {
            Console.WriteLine("Invalid username. Please enter a valid username.");
            return;
        }

        if (followers.ContainsKey(followUsername))
        {
            followers[followUsername].Add(username);
        }
        else
        {
            followers[followUsername] = new List<string> { username };
        }

        Console.WriteLine($"You are now following {followUsername}.");
    }

    static void ShowFollowers()
    {
        Console.Write("\nEnter your username: ");
        string username = Console.ReadLine();
        if (string.IsNullOrEmpty(username))
        {
            Console.WriteLine("Invalid username. Please enter a valid username.");
            return;
        }

        if (followers.ContainsKey(username))
        {
            Console.WriteLine($"\nFollowers of {username}:");
            foreach (var follower in followers[username])
            {
                Console.WriteLine(follower);
            }
        }
        else
        {
            Console.WriteLine("You don't have any followers.");
        }
    }

    static void ShowFollowing()
    {
        Console.Write("\nEnter your username: ");
        string username = Console.ReadLine();
        if (string.IsNullOrEmpty(username))
        {
            Console.WriteLine("Invalid username. Please enter a valid username.");
            return;
        }

        Console.WriteLine($"\nUsers followed by {username}:");
        foreach (var user in followers.Keys)
        {
            if (followers[user].Contains(username))
            {
                Console.WriteLine(user);
            }
        }
    }
}