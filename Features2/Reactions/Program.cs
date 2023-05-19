using System;

class PUPHubChats3
{

    static void Main(string[] args)
    {

        Console.
              WriteLine
              ("Choose a reaction:\n1. HappyFace \n2. SadFace\n3. Heart\n4. Crying\n5. BrokenHearted\n6. SmilingWithGlasses\n7. Angry");

        int userInput = Convert.ToInt32(Console.ReadLine());
        string reaction = "";
        switch (userInput)
        {

            case 1:
                reaction = "HappyFace";
                break;
            case 2:
                reaction = "SadFace";
                break;
            case 3:
                reaction = "Heart";
                break;
            case 4:
                reaction = "Crying";
                break;
            case 5:
                reaction = "BrokenHearted";
                break;
            case 6:
                reaction = "SmilingWithGlasses";
                break;
            case 7:
                reaction = "Angry";
                break;

            default:
                Console.WriteLine("Invalid input. No Reaction selected.");
                break;
        }

        if (!string.IsNullOrEmpty(reaction))
        {

            Console.WriteLine($"You selected the Reaction: {reaction}");

        }

        Console.ReadLine();

    }

}