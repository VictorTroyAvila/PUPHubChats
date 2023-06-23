using System;
using System.Collections.Generic;


using GroupChat
{
	public class Primary
	{
		static Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to our Group Chat System!");

			while (true)
			{
				Console.WriteLine("\n1. Join Group");
				Console.WriteLine("2. Show Members in Group");
				Console.WriteLine("3. Show Groups Joined");
				Console.WriteLine("4. Create Group");
				Console.WriteLine("5. Exit");
				Console.Write("\nEnter your choice: ");
				int choice = Convert.ToInt32(Console.ReadLine());

				switch (choice)
				{
					case 1:
						JoinGroup();
						break;
					case 2:
						ShowGroupMembers();
						break;
					case 3:
						ShowJoinedGroups();
						break;
					case 4:
						CreateGroup();
						break;
					case 5:
						Console.WriteLine("Exiting the program...");
						return;
					default:
						Console.WriteLine("Invalid choice. Please try again.");
						break;
				}
			}
		}

		static void JoinGroup()
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

		static void ShowGroupMembers()
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

		static void ShowJoinedGroups()
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

		static void CreateGroup()
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
	}
}