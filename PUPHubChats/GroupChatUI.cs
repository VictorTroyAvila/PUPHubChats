using System;
using System.Collections.Generic;
using PUPHubChatsData;
using PUPHubChatsRules;

public class GroupChatUI
{
        public static void GroupChat()
        {
            GroupChatRules rules = new GroupChatRules();
            Console.WriteLine("----- GROUP CHAT -----");

            
                Console.WriteLine("\n1. Join Group");
                Console.WriteLine("2. Show Members in Group");
                Console.WriteLine("3. Show Groups Joined");
                Console.WriteLine("4. Create Group");
                Console.WriteLine("5. View Groups");
                Console.WriteLine("6. Back");
                Console.Write("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter your username: ");
                        string username = Console.ReadLine();
                        Console.Write("Enter the name of the group you want to join: ");
                        string groupNameToJoin = Console.ReadLine();
                        rules.JoinGroup(username, groupNameToJoin);
                        break;
                    case 2:
                        Console.Write("Enter the name of the group: ");
                        string groupNameToShowMembers = Console.ReadLine();
                        rules.ShowGroupMembers(groupNameToShowMembers);
                        break;
                    case 3:
                        Console.Write("Enter your username: ");
                        string usernameToShowGroups = Console.ReadLine();
                        rules.ShowJoinedGroups(usernameToShowGroups);
                        break;
                    case 4:
                        Console.Write("Enter your username: ");
                        string usernameToCreateGroup = Console.ReadLine();
                        Console.Write("Enter the name of the group you want to create: ");
                        string groupNameToCreate = Console.ReadLine();
                        rules.CreateGroup(usernameToCreateGroup, groupNameToCreate);
                        break;
                    case 5:
                        rules.ViewGroups();
                        break;
                    case 6:
                        Core.CoreUI();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
            }
        }
    }

