using Xunit;

namespace Greed.Tests
{
    public class ScoringStrategyTests
    {
        [Fact]
        public void FakeShouldReturn0()
        {

            var strategy = new FakeRollScoringStrategy();
            var roll = new Roll {2, 2, 3, 4, 4};
            Assert.Equal(0,strategy.Score(roll));
        }
    }

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

    public class FakeRollScoringStrategy:IRollScoringStrategy
    {
        public int Score(Roll roll)
        {
            return 0;
        }
    }
}