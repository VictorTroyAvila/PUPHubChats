using System;
using System.Collections.Generic;

class MuteRules
{
    public static void MuteMember(Model member)
    {
        Console.WriteLine($"{member.Name} has been muted.");
    }

    public static void UnmuteMember(Model member)
    {
        Console.WriteLine($"{member.Name} has been unmuted.");
    }
}