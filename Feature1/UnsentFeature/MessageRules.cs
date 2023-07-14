using System;
using System.Collections.Generic;

namespace Feature1
{
    class MessageRules
    {
        public bool CheckIfMessageSent(string userInput)
        {
            if (userInput == "yes")
            {
                Console.WriteLine("Message Has Been Unsent");
                return true;
            }
            else if (userInput == "no")
            {
                Console.WriteLine("Message Has Been Sent");
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                return false;
            }
        }
    }
}