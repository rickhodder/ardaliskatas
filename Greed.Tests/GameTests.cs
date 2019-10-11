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
            var score = game.Score();
            Assert.Equal(0, score);
        }
    }

}
