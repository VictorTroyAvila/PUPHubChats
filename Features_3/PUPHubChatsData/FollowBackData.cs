using System;
using System.Collections.Generic;

public class FollowBackData
{
    private List<string> followers = new List<string>();
    private List<string> following = new List<string>();

    public void FollowUser(string username)
    {
        following.Add(username);
        Console.WriteLine("You are now following " + username);
    }

    public void ShowFollowers()
    {
        Console.WriteLine("Followers:");
        foreach (var follower in followers)
        {
            Console.WriteLine(follower);
        }
    }

    public void ShowFollowing()
    {
        Console.WriteLine("Following:");
        foreach (var user in following)
        {
            Console.WriteLine(user);
        }
    }
}