namespace Feature1
{
    class MessageRules
    {
        public bool CheckIfMessageSent(string userInput)
        {
            if (userInput == "yes")
            {
                return true;
            }
            else if (userInput == "no")
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}