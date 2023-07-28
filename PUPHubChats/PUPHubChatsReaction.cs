using System;

public class PUPHubChatsReaction
{
    public static void React()
    {
        ReactionApp reactionApp = new ReactionApp();
        reactionApp.Start();
    }
}
public class ReactionApp
{
    private ReactionData reactionData;
    private ReactionRules reactionRules;
    private ReactionModel reactionModel;

    public ReactionApp()
    {
        reactionData = new ReactionData();
        reactionRules = new ReactionRules();
        reactionModel = new ReactionModel();
    }

    public void Start()
    {
        ReactionApp reactionApp = new ReactionApp();

        //Console.WriteLine("Select message to react to");
        //Connect to database print out lahat ng message history
        //selectedmsg = Console.ReadLine();
        //Connect sa database retrieve selected msg

        Console.WriteLine("Select a reaction:");
        reactionApp.DisplayReactions();

        Console.Write("Enter the reaction number: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int reactionNumber))
        {
            Enum ChosenReaction = reactionRules.GetReaction(reactionNumber);
            Console.WriteLine("You reacted "+ChosenReaction+" to this message \n"//+selectedmsg
            );
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid reaction number.");
        }
    }
    public void DisplayReactions()
    {
        foreach (ReactionModel.PUPHubReactions reaction in Enum.GetValues(typeof(ReactionModel.PUPHubReactions)))
        {
            Console.WriteLine($"{(int)reaction + 1}. {reaction}");
        }
    }
}
