namespace Greed.Tests
{
    public class FakeRollScoringStrategy:IRollScoringStrategy
    {
        public int Score(Roll roll)
        {
            return 0;
        }
    }
}