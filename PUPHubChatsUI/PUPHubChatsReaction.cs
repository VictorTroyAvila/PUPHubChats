﻿using System;

public class PUPHubChatsReaction
{
    static void Main()
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
        reactionRules = new ReactionRules(reactionData);
        reactionModel = new ReactionModel(reactionData);
    }

    public void Start()
    {
        Console.WriteLine("Select a reaction:");
        reactionRules.DisplayReactions();

        Console.Write("Enter the reaction number: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int reactionNumber))
        {
            reactionModel.ProcessReaction(reactionNumber);
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid reaction number.");
        }
    }
}


