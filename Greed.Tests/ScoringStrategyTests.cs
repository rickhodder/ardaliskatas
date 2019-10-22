using Xunit;

namespace Greed.Tests
{
    public class ScoringStrategyTests
    {
        [Fact]
        public void FakeShouldReturn0()
        {

            var strategy = new FakeRollScoringStrategy();
            var roll = new Roll { 2, 2, 3, 4, 4 };
            Assert.Equal(0, strategy.Score(roll));
        }
    }
}