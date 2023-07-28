class PUPHubChatsMute
{
    private static object memberToMUte;

    static void Main(string[] args)
    {
        Data data = new Data();

        Console.WriteLine("Mute");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Mute a member");
            Console.WriteLine("2. Show muted members");
            Console.WriteLine("3. Unmute a member");
            Console.WriteLine("4. Exit");
            Console.Write("Please enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the member name to mute: ");
                    string memberNameToMute = Console.ReadLine();
                    Model memberToMute = new Model { Name = memberNameToMute };
                    if (!data.ContainsMember(memberToMute))
                    {
                        data.AddMember(memberToMute);
                        Console.WriteLine($"{memberToMUte} has been Muted.");
                    }
                    else
                    {
                        Console.WriteLine($"{memberNameToMute} is already muted.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Muted members:");
                    foreach (Model mutedMember in data.GetMutedMembers())
                    {
                        Console.WriteLine(mutedMember.Name);
                    }
                    break;
                case "3":
                    Console.Write("Enter the member name to unmute: ");
                    string memberNameToUnmute = Console.ReadLine();
                    Model memberToUnmute = new Model { Name = memberNameToUnmute };
                    if (data.ContainsMember(memberToUnmute))
                    {
                        data.RemoveMember(memberToUnmute);
                        Console.WriteLine($"{memberToUnmute} has been Unmute.");
                    }
                    else
                    {
                        Console.WriteLine($"{memberNameToUnmute} is not muted.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

internal class Data
{
    internal void AddMember(Model memberToMute)
    {
        throw new NotImplementedException();
    }

    internal bool ContainsMember(Model memberToUnmute)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Model> GetMutedMembers()
    {
        throw new NotImplementedException();
    }

    internal void RemoveMember(Model memberToUnmute)
    {
        throw new NotImplementedException();
    }
}

internal class Model
{
    public string? Name { get; internal set; }
}