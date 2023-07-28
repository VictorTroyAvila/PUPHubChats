using System;

public class SearchData 
{
    private List<SearchModel> sourceList;

    public SearchData ()
    {
        sourceList = new List<SearchModel>
        {
            new SearchModel { Name = "victor avila" },
            new SearchModel { Name = "dhuke marquez" },
            new SearchModel { Name = "jemen pastor" },
            new SearchModel { Name = "jc remolacio" },
            new SearchModel { Name = "yuki villanueva" },
            new SearchModel { Name = "regina lopez" },
        };
    }

    public List<SearchModel> GetAllPeople()
    {
        return sourceList;
    }
    
    public static bool verifyStudent(string search, List<string> students)
    {
        bool result = false;

        foreach (var student in students)
        {
            if (student == search)
            {
                result = true;
            }
        }
        return result;
    }
    public static string MessageHistory(string MessageData)
    {
        List<string> msgHistory = new List<string>();

        msgHistory.Add(MessageData);

        return "";
    }
}
