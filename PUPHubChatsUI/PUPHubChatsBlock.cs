using System;

class PUPHubChatsBlock
{
    static void Main(string[] args)
    {
        DataStorage dataStorage = new DataStorage();

        Console.WriteLine("Welcome to the Member Blocking System!");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Block a member");
            Console.WriteLine("2. Show blocked members");
            Console.WriteLine("3. Unblock a member");
            Console.WriteLine("4. Exit");
            Console.Write("Please enter your choice: ");
            string choice = Console.ReadLine();

            if (!Rules.IsValidChoice(choice))
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the member name to block: ");
                    string memberToBlock = Console.ReadLine();
                    if (!dataStorage.IsMemberBlocked(memberToBlock))
                    {
                        dataStorage.BlockMember(memberToBlock);
                        Console.WriteLine($"{memberToBlock} has been blocked.");
                    }
                    else
                    {
                        Console.WriteLine($"{memberToBlock} is already blocked.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Blocked members:");
                    List<MemberModel> blockedMembers = dataStorage.GetBlockedMembers();
                    foreach (MemberModel blockedMember in blockedMembers)
                    {
                        Console.WriteLine(blockedMember.Name);
                    }
                    break;
                case "3":
                    Console.Write("Enter the member name to unblock: ");
                    string memberToUnblock = Console.ReadLine();
                    if (dataStorage.IsMemberBlocked(memberToUnblock))
                    {
                        dataStorage.UnblockMember(memberToUnblock);
                        Console.WriteLine($"{memberToUnblock} has been unblocked.");
                    }
                    else
                    {
                        Console.WriteLine($"{memberToUnblock} is not blocked.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
