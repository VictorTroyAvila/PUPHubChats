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
}
