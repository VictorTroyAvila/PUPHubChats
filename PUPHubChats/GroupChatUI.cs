using System;
using System.Collections.Generic;
using PUPHubChatsData;
using PUPHubChatsRules;
using UI;

public class GroupChatUI
{
    private GroupChatData data;
    public static void GroupChat()
        {
            GroupChatRules rules = new GroupChatRules();
            GroupChatUI groupChatUI = new GroupChatUI();
            
            GCMM:
            Console.WriteLine("----- GROUP CHAT -----");

            
                Console.WriteLine("\n1. Join Group");
                Console.WriteLine("2. Message Group");
                Console.WriteLine("3. Show Members in Group");
                Console.WriteLine("4. Show Groups Joined");
                Console.WriteLine("5. Create Group");
                Console.WriteLine("6. View Groups");
                Console.WriteLine("7. Back");
                Console.Write("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter your username: ");
                        string username = Console.ReadLine();
                        Console.Write("Enter the name of the group you want to join: ");
                        string groupNameToJoin = Console.ReadLine();
                if(rules.IsJoinedGroup(username, groupNameToJoin))
                {
                    Console.WriteLine($"You have joined the group: {groupNameToJoin}.");
                }
                else 
                {
                    Console.WriteLine($"The group {groupNameToJoin} does not exist.");
                }
                goto GCMM;

                    case 3:
                        Console.Write("Enter the name of the group: ");
                        string groupNameToShowMembers = Console.ReadLine();
                        groupChatUI.ShowGroupMembers(groupNameToShowMembers);
                        break;

                    case 4:
                        Console.Write("Enter your username: ");
                        string usernameToShowGroups = Console.ReadLine();
                        Console.WriteLine(rules.ShowJoinedGroups(usernameToShowGroups));
                goto GCMM;

                    case 5:
                        Console.Write("Enter your username: ");
                        string usernameToCreateGroup = Console.ReadLine();
                        Console.Write("Enter the name of the group you want to create: ");
                        string groupNameToCreate = Console.ReadLine();
                if (rules.CheckGroup(usernameToCreateGroup, groupNameToCreate))
                {
                    Console.WriteLine($"The group {groupNameToCreate} already exists.");
                }
                else
                {
                    Console.WriteLine($"Group {groupNameToCreate} created successfully.");
                    rules.CreateGroup(usernameToCreateGroup, groupNameToCreate);
                    
                }
                goto GCMM;

                    case 6:
                        Console.WriteLine("\nExisting Groups: "+rules.ViewGroups());
                        goto GCMM;

                    case 7:
                        Core.CoreUI();
                        break;

                    case 2:
                        ChatUI.ComposeToGroup();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        goto GCMM;
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
}

