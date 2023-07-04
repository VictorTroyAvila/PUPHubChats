class ChatRules
{
    private string[] restrictedWords = { "bobo", "tanga", "gago", "inutil", "pota", "potanginamo", "pakyu", "tuleg", "noob", "idiot" };
    private bool isProfessor;

    public ChatRules(bool isProfessor)
    {
        this.isProfessor = isProfessor;
    }

    public bool CheckRestrictedWords(string message)
    {
        // Students have additional restrictions
        if (!isProfessor && message.ToLower().Contains("exam"))
        {
            return true;
        }

        foreach (string word in restrictedWords)
        {
            if (message.ToLower().Contains(word.ToLower()))
            {
                return true;
            }
        }

        return false;
    }
}