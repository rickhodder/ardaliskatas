using System.Linq;

namespace Greed
{
    public class MultipleRollScoringStrategy : IRollScoringStrategy
    {
        private readonly int _die;
        private readonly int _dieCount;
        private readonly int _expectedScore;

        public MultipleRollScoringStrategy(int die, int dieCount, int expectedScore)
        {
            _die = die;
            _dieCount = dieCount;
            _expectedScore = expectedScore;
        }

        public int Score(Roll roll)
        {
            if (roll.Count(r => r == _die) >= _dieCount)
                return _expectedScore;

            return 0;

        }
    }
}