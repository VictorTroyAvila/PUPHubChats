using System;
using System.Collections.Generic;

namespace GroupChat
{

    public class GroupChatModel
    {
        private GroupChatData groupChatData = new GroupChatData();

        public void AskUserRole()
        {
            Console.Write("Please enter whether you're a student or a professor: ");
            string role = Console.ReadLine().ToLower();

            if (role == "student" || role == "professor")
            {
                groupChatData.Run(role);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'student' or 'professor'.");
            }
        }
    }
}