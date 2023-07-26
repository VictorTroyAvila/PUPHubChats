using System;
using System.Collections.Generic;

namespace PUPHubChatsRules
{
    public class BlockRules
    {
        public static bool IsValidChoice(string choice)
        {
            return choice == "1" || choice == "2" || choice == "3" || choice == "4";
        }
    }
}