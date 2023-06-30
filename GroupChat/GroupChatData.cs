
namespace GroupChat
{
	public class GroupChatData
{
	private Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
	private GroupChatRules rules = new GroupChatRules();

	public void Run()
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
					rules.JoinGroup(groups);
					break;
				case 2:
					rules.ShowGroupMembers(groups);
					break;
				case 3:
					rules.ShowJoinedGroups(groups);
					break;
				case 4:
					rules.CreateGroup(groups);
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
}