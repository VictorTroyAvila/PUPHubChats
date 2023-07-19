using System;
using System.Collections.Generic;

class RestrictionsModel
{
    private string userType = "";

    public string GetUserType()
    {
        Console.Write("Are you a student or a professor? (Enter 'student' or 'professor'): ");
        string input = Console.ReadLine().ToLower();

        if (input != "student" && input != "professor")
        {
            Console.WriteLine("Invalid user type. Please try again.");
            return GetUserType();
        }

        userType = input;
        return userType;
    }
}