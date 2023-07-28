using System;
using System.Collections.Generic;
using PUPHubChatsData;

public class ReactionRules
{
    ReactionData reactionData = new ReactionData();
    public Enum GetReaction(int reaction)
    {
        Enum selectedReaction = reactionData.ProcessReaction(reaction);
        return selectedReaction;
    }
}
