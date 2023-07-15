public class FollowBackData
{
    private Dictionary<string, List<string>> followers = new Dictionary<string, List<string>>();

    public void FollowUser()
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

    public void ShowFollowers()
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

    public void ShowFollowing()
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