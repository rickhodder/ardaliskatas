using Xunit;

namespace Greed.Tests
{
    public class ScorerTests
    {
        [Fact]
        public void ShouldHaveScoreMethod()
        {
            var scorer = new RollScorer();
            var roll = new Roll();
            
            Assert.Equal(0, scorer.Score(roll));
        }
    }
}