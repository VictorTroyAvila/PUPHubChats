using System;
using System.Collections.Generic;

class RestrictionRules
{
    private string[] restrictedWords = { "bobo", "tanga", "gago", "inutil", "pota", "potanginamo", "pakyu", "tuleg", "noob", "idiot", "tanginamo" };
    private string userType;

    public RestrictionRules(string userType)
    {
        this.userType = userType;
    }

    public bool CheckRestrictedWords(string message)
    {
        // Students have additional restrictions
        if (userType == "student" && message.ToLower().Contains("exam"))
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
