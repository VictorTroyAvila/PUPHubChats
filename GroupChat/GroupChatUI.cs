
using System;
using System.Collections.Generic;

namespace GroupChat
{

    public class GroupChatUI
    {
        public void JoinGroup(Dictionary<string, List<string>> groups)
        {
            Console.Write("\nEnter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter the name of the group you want to join: ");
            string groupName = Console.ReadLine();

            if (groups.ContainsKey(groupName))
            {
                groups[groupName].Add(username);
                Console.WriteLine($"You have joined the group: {groupName}.");
            }
            else
            {
                Console.WriteLine($"The group {groupName} does not exist.");
            }
        }

        public void ShowGroupMembers(Dictionary<string, List<string>> groups)
        {
            Console.Write("\nEnter the name of the group: ");
            string groupName = Console.ReadLine();

            if (groups.ContainsKey(groupName))
            {
                Console.WriteLine($"\nMembers of the group {groupName}:");
                foreach (var member in groups[groupName])
                {
                    Console.WriteLine(member);
                }
            }
            else
            {
                Console.WriteLine("The group does not exist.");
            }
        }

        public void ShowJoinedGroups(Dictionary<string, List<string>> groups)
        {
            Console.Write("\nEnter your username: ");
            string username = Console.ReadLine();

            Console.WriteLine($"\nGroups joined by {username}:");
            bool foundGroup = false;
            foreach (var group in groups.Keys)
            {
                if (groups[group].Contains(username))
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

        public void CreateGroup(Dictionary<string, List<string>> groups)
        {
            Console.Write("\nEnter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter the name of the group you want to create: ");
            string groupName = Console.ReadLine();

            if (groups.ContainsKey(groupName))
            {
                Console.WriteLine($"The group {groupName} already exists.");
            }
            else
            {
                groups[groupName] = new List<string> { username };
                Console.WriteLine($"Group {groupName} created successfully.");
            }
        }

        public void ViewGroups(Dictionary<string, List<string>> groups)
        {
            Console.WriteLine("\nExisting Groups:");

            if (groups.Count > 0)
            {
                foreach (var group in groups.Keys)
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
}

