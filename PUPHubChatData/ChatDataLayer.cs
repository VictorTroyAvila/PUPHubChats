using PUPHubChatsModels;
using System.Reflection.Metadata.Ecma335;

namespace PUPHubChatsData
{
    public class ChatsDataLayer
    {
        private List<Students> Students { get; set; }
        public class InMemoryData
        {
            public static List<String> prof = new List<String>
            { "Dr.Orozco", "Mr.Almazan", "Mr.Macha", "Mr.Dela Cruz", "Ms.Quinsayas" };
        }

        public interface DataServices
        {
            List<Students> addData();
            void saveData();
            void removeData();
        }
        public List<Students> GetStudents()
        {
            return Students;
        }
     
    }
}