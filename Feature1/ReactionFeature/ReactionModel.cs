using System;
using System.Collections.Generic;

namespace Feature1
{
    public class ReactionModel
    {
        public ReactionData reactionData;

        public ReactionModel(ReactionData data)
        {
            reactionData = data;
        }

        public void ProcessReaction(int reactionNumber)
        {
            if (Enum.IsDefined(typeof(ReactionData.PUPHubReactions), reactionNumber - 1))
            {
                ReactionData.PUPHubReactions selectedReaction = (ReactionData.PUPHubReactions)(reactionNumber - 1);
                Console.WriteLine($"You selected: {selectedReaction}");
            }
            else
            {
                Console.WriteLine("Invalid reaction number!");
            }
        }
    }
}