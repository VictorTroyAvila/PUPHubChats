using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features2
{
    public class SearchEngine
    {
        public SearchEngine(string input) 
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

            List<string> searchResults = PerformSearch(sourceList, input);

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

        public static List<string> PerformSearch(List<string> sourceList, string input)
        {
            List<string> searchResults = new List<string>();

            foreach (string item in sourceList)
            {
                if (item.Contains(input, StringComparison.OrdinalIgnoreCase))
                {
                    searchResults.Add(item);
                }
            }

            return searchResults;
        }
    }
    }
