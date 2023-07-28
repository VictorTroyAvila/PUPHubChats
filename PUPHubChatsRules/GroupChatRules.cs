using System;
using System.Collections.Generic;

    public class GroupChatRules
    {
        private GroupChatData data;

        public GroupChatRules()
        {
            data = new GroupChatData();
        }

        public bool IsJoinedGroup(string username, string groupName)
        {
            if (data.Groups.ContainsKey(groupName))
            {
                data.Groups[groupName].Add(username);
                return true;
            }
            else
            {
                return false;
            }
        }
        public string ShowJoinedGroups(string username)
        {
            Console.WriteLine($"\nGroups joined by {username}:");
            bool foundGroup = false;
            foreach (var group in data.Groups.Keys)
            {
                if (data.Groups[group].Contains(username))
                {
                return group;
                    foundGroup = true;
                }
            }

            if (!foundGroup)
            {
                return "You haven't joined any groups.";
            }
        return "";
        }
    public void CreateGroup(string username, string groupName)
    {
            data.Groups[groupName] = new List<string> { username };
    }
    public bool CheckGroup(string username, string groupName)
        {
            if (data.Groups.ContainsKey(groupName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ViewGroups()
        {
            if (data.Groups.Count > 0)
            {
                foreach (var group in data.Groups.Keys)
                {
                    return group;
                }
            }
            else
            {
                return "No groups available.";
            }
        return "";
        }
    }
