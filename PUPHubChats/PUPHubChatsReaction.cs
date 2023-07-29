using Data;
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
        SQLDataMessageStatus sqlMStatus = new SQLDataMessageStatus();


        Console.WriteLine("Select a reaction:");
        reactionApp.DisplayReactions();

        Console.Write("Enter the reaction number: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int reactionNumber))
        {
            Enum ChosenReaction = reactionRules.GetReaction(reactionNumber);
            sqlMStatus.EditMessageReaction(ChosenReaction.ToString());

            Console.WriteLine("The Reaction you selected is: " + ChosenReaction);
            Core.CoreUI();
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
