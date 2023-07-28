using PUPHubChatsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUPHubChatsRules
{
    public class MessageRules
    {
        DateTime currentDateTime = DateTime.Now;
        SearchData searchData = new SearchData();
        public string FormulateMessageData(string search, string Message)
        {
            string msgData;
            msgData = search + "\n" + currentDateTime + "\n" + Message + "\n";
            return msgData;
        }
        public string FormulateMessageData(string Message)
        {
            string msgData;
            msgData = currentDateTime + "\n" + Message + "\n";
            return msgData;
        }
    }
}
