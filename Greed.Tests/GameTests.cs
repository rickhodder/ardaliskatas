using System;
using Xunit;

namespace Greed.Tests
{
    public class GameTests
    {
        private readonly Game _game = new Game();

        [Fact]
        public void ShouldScoreRollContainingOne_100()
        {
            var roll = new Roll { 1, 2, 3, 4, 4 };
            var score = _game.Score(roll);
            Assert.Equal(100, score);
        }

        [Fact]
        public void ShouldScoreRollContainingFive_50()
        {
            var roll = new Roll { 5, 2, 3, 4, 4 };
            var score = _game.Score(roll);
            Assert.Equal(50, score);
        }

        [Fact]
        public void ShouldScoreRollWithoutOneOrFive_0()
        {
            var roll = new Roll { 2, 2, 3, 4, 4 };
            var score = _game.Score(roll);
            Assert.Equal(0, score);
        }

        [Fact]
        public void ShouldScoreRollWithOneAndFive_150()
        {
            var roll = new Roll { 1, 2, 3, 4, 5 };
            var score = _game.Score(roll);
            Assert.Equal(150, score);
        }

        [Fact]
        public void ShouldScoreTripleOnes_1100()
        {
            var roll = new Roll { 1, 1, 1, 4, 2 };
            var score = _game.Score(roll);
            Assert.Equal(1100, score);
        }

        [Fact]
        public void ShouldScoreRollTripleTwos_200()
        {
            var roll = new Roll { 2, 2, 2, 4, 3 };
            var score = _game.Score(roll);
            Assert.Equal(200, score);
        }

        [Fact]
        public void ShouldScoreRollTripleThrees_300()
        {
            var roll = new Roll { 3, 3, 3, 4, 4 };
            var score = _game.Score(roll);
            Assert.Equal(300, score);
        }

        [Fact]
        public void ShouldScoreRollTripleFours_400()
        {
            var roll = new Roll { 3, 3, 4, 4, 4 };
            var score = _game.Score(roll);
            Assert.Equal(400, score);
        }

        [Fact]
        public void ShouldScoreRollTripleFives_550()
        {
            var roll = new Roll { 3, 3, 5, 5, 5 };
            var score = _game.Score(roll);
            Assert.Equal(550, score);
        }

        [Fact]
        public void ShouldScoreRollTripleSixes_600()
        {
            var roll = new Roll() { 3, 3, 6, 6, 6 };
            var score = _game.Score(roll);
            Assert.Equal(600, score);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 1, 5, 1 }, 1150)]
        [InlineData(new int[] { 2, 3, 4, 6, 2 }, 0)]
        [InlineData(new int[] { 3, 4, 5, 3, 3 }, 350)]
        [InlineData(new int[] { 1, 1, 1, 1, 1 }, 1100)]
        [InlineData(new int[] { 3, 1, 2, 3, 3 }, 400)]

        // 
        public void TestCases(int[] dice, int score)
        {
            // had to do this because inlinedata doesnt take classes
            var roll = new Roll();
            roll.AddRange(dice);
            Assert.Equal(score, _game.Score(roll));
        }
    }
}
