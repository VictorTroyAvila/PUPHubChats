using System;
using System.Collections.Generic;

public class EnableDisableRules
{
    public bool ShouldDisableChat(string message)
    {
        return message.ToLower() == "disable";
    }

    public bool ShouldEnableChat(string message)
    {
        return message.ToLower() == "enable";
    }

    public bool ShouldExit(string message)
    {
        return message.ToLower() == "exit";
    }
}