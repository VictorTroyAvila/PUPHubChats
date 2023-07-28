using System;

public class ReactionRules
{
    public void DisplayReactions()
    {
        foreach (ReactionModel.PUPHubReactions reaction in Enum.GetValues(typeof(ReactionModel.PUPHubReactions)))
        {
            Console.WriteLine($"{(int)reaction + 1}. {reaction}");
        }
    }
}
