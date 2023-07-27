using System;
using System.Collections.Generic;

    public class GroupChatData
    {
        public Dictionary<string, List<string>> Groups { get; set; }

        public GroupChatData()
        {
            Groups = new Dictionary<string, List<string>>();
        }
    }

