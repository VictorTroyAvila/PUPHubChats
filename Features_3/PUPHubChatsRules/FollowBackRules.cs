public class FollowBackRules
{
    private FollowBackData data = new FollowBackData();

    public void FollowUser(string username)
    {
        data.FollowUser(username);
    }

    public List<string> GetFollowers()
    {
        return data.GetFollowers();
    }

    public List<string> GetFollowing()
    {
        return data.GetFollowing();
    }
}