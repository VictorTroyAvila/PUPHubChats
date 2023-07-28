using System;

public class SearchService
{
    public List<SearchModel> PerformSearch(List<SearchModel> sourceList, string searchKeyword)
    {
        List<SearchModel> results = new List<SearchModel>();
        foreach (SearchModel person in sourceList)
        {
       
            if (person.Name.Contains(searchKeyword, StringComparison.OrdinalIgnoreCase))
            {
                results.Add(person);
            }
        }
        return results;
    }
    public static bool SearchUser(string search)
    {
        bool result = false;
        SearchData dataStore = new SearchData();
        List<SearchModel> sourceList = dataStore.GetAllPeople();

        string searchKeyword = search;

        SearchService searchService = new SearchService();
        List<SearchModel> searchResults = searchService.PerformSearch(sourceList, searchKeyword);

        if (searchResults.Count > 0)
        {
            foreach (SearchModel person in searchResults)
            {
                result = true;
            }
        }
        else
        {
            result = false;
        }
        return result;
    }
}
