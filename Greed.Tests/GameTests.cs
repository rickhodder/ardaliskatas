using System;
using Xunit;

namespace Greed.Tests
{
    public class GameTests
    {
        [Fact]
        public void ShouldScoreRollContainingOne_100()
        {
            var game = new Game();
            var roll = new int[] {1, 2, 3, 4, 4};
            var score = game.Score(roll);
            Assert.Equal(100, score);
        }

        [Fact]
        public void ShouldScoreRollContainingFive_50()
        {
            var game = new Game();
            var roll = new int[] { 5, 2, 3, 4, 4 };
            var score = game.Score(roll);
            Assert.Equal(50, score);
        }
    }

}
