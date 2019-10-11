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

        [Fact]
        public void ShouldScoreRollTripleThrees_300()
        {
            var game = new Game();
            var roll = new int[] { 3,3,3, 4, 4 };
            var score = game.Score(roll);
            Assert.Equal(300, score);
        }

        [Fact]
        public void ShouldScoreRollTripleFours_400()
        {
            var game = new Game();
            var roll = new int[] { 3, 3, 4, 4, 4 };
            var score = game.Score(roll);
            Assert.Equal(400, score);
        }

        [Fact]
        public void ShouldScoreRollTripleFives_550()
        {
            var game = new Game();
            var roll = new int[] { 3, 3, 5, 5, 5 };
            var score = game.Score(roll);
            Assert.Equal(550, score);
        }

        [Fact]
        public void ShouldScoreRollTripleSixes_600()
        {
            var game = new Game();
            var roll = new int[] { 3, 3, 6, 6, 6 };
            var score = game.Score(roll);
            Assert.Equal(600, score);
        }

    }

}
