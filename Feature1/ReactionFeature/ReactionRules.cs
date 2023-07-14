using System;
using System.Collections.Generic;

namespace Feature1
{
    public class ReactionRules
    {
        public ReactionData reactionData;

        public ReactionRules(ReactionData data)
        {
            reactionData = data;
        }

        public void DisplayReactions()
        {
            foreach (ReactionData.PUPHubReactions reaction in Enum.GetValues(typeof(ReactionData.PUPHubReactions)))
            {
                Console.WriteLine($"{(int)reaction + 1}. {reaction}");
            }
        }
    }
}