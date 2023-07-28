using System.ComponentModel;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using Data;
using PUPHubChatsData;
using PUPHubChatsRules;
using UI;

public class Core
{
    public static void CoreUI()
    {

        String choice;

        SelectAction:
        Console.WriteLine("Select action");
        Console.WriteLine("[1] Group Message");
        Console.WriteLine("[2] Compose Message");
        Console.WriteLine("[3] React to Message");
        Console.WriteLine("[4] Unsend a Message");
        Console.WriteLine("[5] Archive a Message");
        Console.WriteLine("[6] Delete Message");
        Console.WriteLine("[7] Mute User");
        Console.WriteLine("[8] Block User");
        Console.WriteLine("[9] Enable and Disable");
        Console.WriteLine("[10] Follow System");
        Console.WriteLine("[11] Restrictions");
        Console.WriteLine("[X] Exit");
        choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                GroupChatUI.GroupChat();
                break;
            case "2":
                ChatUI.Compose();
                break;
            case "3":
                PUPHubChatsReaction.React();
                break;
            case "4":
                PUPHubChatUnsend.Unsend();
                break;
            case "5":
                PUPHubChatsArchive.Archive();
                break;
            case "6":
                DeleteUI.DoDelete();
                break;
            case "7":
                PUPHubChatsMute.Mute();
                break;
            case "8":
                PUPHubChatsBlock.Block();
                break;
            case "9":
                EnableDisableUI.EnD();
                break;
            case "10":
                FollowBackUI.Follow();
                break;
            case "11":
                RestrictionUI.Restrict();
                break;
            case "X":
            case "x":
                Console.WriteLine(" Thank you");
                break;
            default:
                Console.WriteLine("Invalid input \n Please Try Again");
                goto SelectAction;

        }
    }
    static void Main(String[] args)
    {
        Console.WriteLine("Press anything to continue");
        Console.ReadLine();
        Core.CoreUI();
    }
}
