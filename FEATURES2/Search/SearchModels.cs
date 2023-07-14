using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> sourceList = new List<string>
        {
            "victor avila",
            "dhuke marquez",
            "jemen pastor",
            "jc remolacio",
            "yuki villanueva",
            "regina lopez",
        };

        Console.Write("Enter Name: ");
        string searchKeyword = Console.ReadLine();

        List<string> searchResults = PerformSearch(sourceList, searchKeyword);

        if (searchResults.Count > 0)
        {
            Console.WriteLine("Search Results:");
            foreach (string result in searchResults)
            {
                Console.WriteLine(result);
            }
        }
        else
        {
            Console.WriteLine("No results found.");
        }
    }

    public static List<string> PerformSearch(List<string> sourceList, string searchKeyword)
    {
        List<string> searchResults = new List<string>();

        foreach (string item in sourceList)
        {
            if (item.Contains(searchKeyword, StringComparison.OrdinalIgnoreCase))
            {
                searchResults.Add(item);
            }
        }

        return searchResults;
    }
}
