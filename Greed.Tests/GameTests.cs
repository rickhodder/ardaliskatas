using System;
using Xunit;

namespace Greed.Tests
{
    public class GameTests
    {
        [Fact]
        public void ShouldScoreDiceRoll()
        {
            var game = new Game();
            var roll = new int[] {1, 2, 3, 4, 4};
            var score = game.Score(roll);
            Assert.Equal(0, score);
        }
    }

}
