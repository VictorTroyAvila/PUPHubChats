using System;

public class UnsendRules
{
    public bool CheckIfMessageUnsent(string userInput)
    {
        if (userInput == "yes")
        {
            return true;
        }
        else if (userInput == "no")
        {
            return false;
        }
        else
        {
            return false;
        }
    }
}