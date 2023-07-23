public class FollowBackData
{
    private List<string> followers = new List<string>();
    private List<string> following = new List<string>();

    public void FollowUser(string username)
    {
        following.Add(username);
    }

    public List<string> GetFollowers()
    {
        return followers;
    }

    public List<string> GetFollowing()
    {
        return following;
    }
}
}