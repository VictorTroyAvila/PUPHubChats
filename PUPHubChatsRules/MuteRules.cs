using System;


public class MuteRules
{
    public static void MuteMember(MuteModel member)
    {
        Console.WriteLine($"{member.Name} has been muted.");
    }

    public static void UnmuteMember(MuteModel member)
    {
        Console.WriteLine($"{member.Name} has been unmuted.");
    }
}