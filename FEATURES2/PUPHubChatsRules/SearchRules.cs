using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {


        Console.Write("Enter Name: ");
        string searchKeyword = Console.ReadLine();

        List<string> searchResults = PerformSearch(sourceList, searchKeyword);

        if (searchResults.Count > 0)
        {
         
            foreach (string result in searchResults)
            {
                
            }
        }
        else
        {
            
        }
        
        }
    }


    