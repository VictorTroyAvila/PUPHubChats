using System;
using System.Collections.Generic;

public class FollowBackRules
{
    private FollowBackData data = new FollowBackData();

    public void FollowUser(string username)
    {
        data.FollowUser(username);
    }

    public void ShowFollowers()
    {
        data.ShowFollowers();
    }

    public void ShowFollowing()
    {
        data.ShowFollowing();
    }
}
}