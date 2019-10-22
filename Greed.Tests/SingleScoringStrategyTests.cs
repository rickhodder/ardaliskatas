using Xunit;

namespace Greed.Tests
{
    public class SingleScoringStrategyTests
    {
        [Fact]
        public void ShouldReturnReturnScore_GivenSingleDie()
        {
            var expectedScore = 2000;
            var strategy = new SingleRollScoringStrategy(4,expectedScore);
            var roll = new Roll { 1, 2, 3, 4, 4 };
            Assert.Equal(expectedScore, strategy.Score(roll));
        }
    }
}