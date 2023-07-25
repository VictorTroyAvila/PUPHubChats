using System;
using System.Collections.Generic;

class RestrictionRules
{
    private string[] restrictedWords = { "bobo", "tanga", "gago", "inutil", "pota", "potanginamo", "pakyu", "tuleg", "noob", "idiot", "tanginamo", "Fuck",
        "Fucky you", "Shit", "Piss off", "Dick head", "Asshole", "Son of a bitch", "Bastard", "Bitch", "Damn", "Holy fuck", "Dumb", "Tarantado", "Yawa", "Punyeta", "Tae", "Pakshet", "BwSIT", "namo", };
    private string userType;

    public RestrictionRules(string userType)
    {
        this.userType = userType;
    }

    public bool CheckRestrictedWords(string message)
    {
        if (userType == "student" && message.ToLower().Contains("Bad Words"))
        {
            return true;
        }

        foreach (string word in restrictedWords)
        {
            if (message.ToLower().Contains(word.ToLower()))
            {
                return true;
            }
        }

        return false;
    }
}
