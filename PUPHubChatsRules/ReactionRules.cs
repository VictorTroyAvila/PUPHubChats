namespace Feature1
{
    public class ReactionRules
    {
        public ReactionData reactionData;

        public ReactionRules(ReactionData data)
        {
            reactionData = data;
        }

        public void DisplayReactions()
        {
            foreach (ReactionData.PUPHubReactions reaction in Enum.GetValues(typeof(ReactionData.PUPHubReactions)))
            {
                Console.WriteLine($"{(int)reaction + 1}. {reaction}");
            }
        }
    }

    public class ReactionData
    {
        internal class PUPHubReactions
        {
            public static explicit operator int(PUPHubReactions v)
            {
                throw new NotImplementedException();
            }
        }
    }
}