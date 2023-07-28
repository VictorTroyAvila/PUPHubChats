using System;

public class SearchUI
{
    public static void Main()
    {
        SearchData dataStore = new SearchData();
        List<SearchModel> sourceList = dataStore.GetAllPeople();

        Console.Write("Enter Name: ");
        string searchKeyword = Console.ReadLine();

        SearchService searchService = new SearchService();
        List<SearchModel> searchResults = searchService.PerformSearch(sourceList, searchKeyword);

        if (searchResults.Count > 0)
        {
            Console.WriteLine("Search Results:");
            foreach (SearchModel person in searchResults)
            {
                Console.WriteLine(person.Name);
            }
        }
        else
        {
            Console.WriteLine("No results found.");
        }
    }
}