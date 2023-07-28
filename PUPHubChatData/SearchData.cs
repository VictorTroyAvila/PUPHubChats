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
}
