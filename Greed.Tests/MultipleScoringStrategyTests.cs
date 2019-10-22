using Xunit;

namespace Greed.Tests
{
    public class MultipleScoringStrategyTests
    {
        [Fact]
        public void ShouldReturnReturnScore_GivenMultipleDie()
        {
            var expectedScore = 2000;
            var dieCount = 2;
            var die = 4;
            var strategy = new MultipleRollScoringStrategy(die,dieCount, expectedScore);
            var roll = new Roll { 1, 2, 3, 4, 4 };
            Assert.Equal(expectedScore, strategy.Score(roll));
        }
    }
}