namespace Feature1
{
    public class ReactionDatas
    {
        public ReactionDatas reactionData;

        public ReactionDatas(ReactionDatas data)
        {
            reactionData = data;
        }

        public void ProcessReaction(int reactionNumber)
        {
            if (Enum.IsDefined(typeof(ReactionDatas.PUPHubReactions), reactionNumber - 1))
            {
                ReactionDatas.PUPHubReactions selectedReaction = (ReactionDatas.PUPHubReactions)(reactionNumber - 1);
                Console.WriteLine($"You selected: {selectedReaction}");
            }
            else
            {
                Console.WriteLine("Invalid reaction number!");
            }
        }

        private class PUPHubReactions
        {
            public static explicit operator PUPHubReactions(int v)
            {
                throw new NotImplementedException();
            }
        }
    }

    public class ReactionData
    {
        internal class PUPHubReactions
        {
            public static explicit operator PUPHubReactions(int v)
            {
                throw new NotImplementedException();
            }
        }
    }
}