using System;
using System.Collections.Generic;

    public class GroupChatRules
    {
        private GroupChatData data;

        public GroupChatRules()
        {
            data = new GroupChatData();
        }

        public void JoinGroup(string username, string groupName)
        {
            if (data.Groups.ContainsKey(groupName))
            {
                data.Groups[groupName].Add(username);
                Console.WriteLine($"You have joined the group: {groupName}.");
            }
            else
            {
                Console.WriteLine($"The group {groupName} does not exist.");
            }
        }

        public void ShowGroupMembers(string groupName)
        {
            if (data.Groups.ContainsKey(groupName))
            {
                Console.WriteLine($"\nMembers of the group {groupName}:");
                foreach (var member in data.Groups[groupName])
                {
                    Console.WriteLine(member);
                }
            }
            else
            {
                Console.WriteLine("The group does not exist.");
            }
        }

        public void ShowJoinedGroups(string username)
        {
            Console.WriteLine($"\nGroups joined by {username}:");
            bool foundGroup = false;
            foreach (var group in data.Groups.Keys)
            {
                if (data.Groups[group].Contains(username))
                {
                    Console.WriteLine(group);
                    foundGroup = true;
                }
            }

            if (!foundGroup)
            {
                Console.WriteLine("You haven't joined any groups.");
            }
        }

        public void CreateGroup(string username, string groupName)
        {
            if (data.Groups.ContainsKey(groupName))
            {
                Console.WriteLine($"The group {groupName} already exists.");
            }
            else
            {
                data.Groups[groupName] = new List<string> { username };
                Console.WriteLine($"Group {groupName} created successfully.");
            }
        }

        public void ViewGroups()
        {
            Console.WriteLine("\nExisting Groups:");

            if (data.Groups.Count > 0)
            {
                foreach (var group in data.Groups.Keys)
                {
                    Console.WriteLine(group);
                }
            }
            else
            {
                Console.WriteLine("No groups available.");
            }
        }
    }
