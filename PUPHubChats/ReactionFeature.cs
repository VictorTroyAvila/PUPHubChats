using System;

public class PUPHubChatsReaction
{

    enum PUPHubReactions
    {
        Like,
        Love,
        Haha,
        Wow,
        Sad,
        Angry,
        RedHeart,
        VioletHeart,
        BlueHeart,
        GreenHeart,
        YellowHeart,
        WaveSign,
        PeaceSign,
        ShhSign,
        HighFiveSign,
        ShakeHandsSign,
        Crying,
        Laughing,
        Inlove,
        Shy,
        Kiss
    }

    static void Main()
    {

        Console.WriteLine("Select a reaction:");
        foreach (PUPHubReactions reaction in Enum.GetValues(typeof(PUPHubReactions)))
        {
            Console.WriteLine($"{(int)reaction + 1}. {reaction}");
        }


        Console.Write("Enter the reaction number: ");
        int reactionNumber = Convert.ToInt32(Console.ReadLine());


        if (Enum.IsDefined(typeof(PUPHubReactions), reactionNumber - 1))
        {
            PUPHubReactions selectedReaction = (PUPHubReactions)(reactionNumber - 1);
            Console.WriteLine($"You selected: {selectedReaction}");
        }
        else
        {
            Console.WriteLine("Invalid reaction number!");
        }
    }
}
