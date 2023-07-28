using System;

public class ReactionData
{
    public void ProcessReaction(int reactionNumber)
    {
        if (Enum.IsDefined(typeof(ReactionModel.PUPHubReactions), reactionNumber - 1))
        {
            ReactionModel.PUPHubReactions selectedReaction = (ReactionModel.PUPHubReactions)(reactionNumber - 1);
            Console.WriteLine($"You selected: {selectedReaction}");
        }
        else
        {
            Console.WriteLine("Invalid reaction number!");
        }
    }
}