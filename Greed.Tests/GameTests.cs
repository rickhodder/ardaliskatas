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

        [Fact]
        public void ShouldScoreRollWithoutOneOrFive_0()
        {
            var game = new Game();
            var roll = new int[] { 2, 2, 3, 4, 4 };
            var score = game.Score(roll);
            Assert.Equal(0, score);
        }

        [Fact]
        public void ShouldScoreRollWithOneAndFive_150()
        {
            var game = new Game();
            var roll = new int[] { 1, 2, 3, 4, 5 };
            var score = game.Score(roll);
            Assert.Equal(150, score);
        }

        [Fact]
        public void ShouldScoreTripleOnes_1100()
        {
            var game = new Game();
            var roll = new int[] { 1, 1, 1, 4, 2 };
            var score = game.Score(roll);
            Assert.Equal(1100, score);
        }

        [Fact]
        public void ShouldScoreRollTripleTwos_200()
        {
            var game = new Game();
            var roll = new int[] { 2, 2, 2, 4, 3 };
            var score = game.Score(roll);
            Assert.Equal(200, score);
        }

    }

}
