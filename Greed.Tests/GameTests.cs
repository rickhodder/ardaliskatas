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

    }

}
