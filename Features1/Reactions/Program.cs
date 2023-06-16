using System;

class PUPHubChats3
{

    public class Reactions
    {
        public Reactions()
        {

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
    }