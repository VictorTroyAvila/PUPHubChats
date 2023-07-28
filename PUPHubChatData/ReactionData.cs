using System;

public class ReactionData
{
    public ReactionModel.PUPHubReactions ProcessReaction(int reactionNumber)
    {
        if (Enum.IsDefined(typeof(ReactionModel.PUPHubReactions), reactionNumber - 1))
        {
            ReactionModel.PUPHubReactions selectedReaction = (ReactionModel.PUPHubReactions)(reactionNumber - 1);
            Enum result = selectedReaction;
            return selectedReaction;
        }
        else
        {
            Console.WriteLine("Invalid reaction number!");
        }
        return 0;
    }
}