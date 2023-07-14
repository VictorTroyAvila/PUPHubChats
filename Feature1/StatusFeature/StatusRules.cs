using System;
using System.Collections.Generic;

namespace Feature1
{
    class StatusRules
    {
        public string GetStatusMessage(string userInput, StatusData statusData)
        {
            string statusMessage;

            if (userInput == statusData.Online)
            {
                statusMessage = "You are currently Online.";
            }
            else if (userInput == statusData.TakingAnExam)
            {
                statusMessage = "You are currently taking an Examination.";
            }
            else if (userInput == statusData.InMarketPlace)
            {
                statusMessage = "You are currently visiting the MarketPlace.";
            }
            else if (userInput == statusData.Playing)
            {
                statusMessage = "You are currently playing.";
            }
            else if (userInput == statusData.Studying)
            {
                statusMessage = "You are currently studying.";
            }
            else if (userInput == statusData.Offline)
            {
                statusMessage = "You are currently Offline.";
            }
            else
            {
                statusMessage = "Invalid status input.";
            }

            return statusMessage;
        }
    }
}