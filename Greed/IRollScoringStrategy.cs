using System.Linq;

namespace Greed
{
    public interface IRollScoringStrategy
    {
        int Score(Roll roll);
    }

    public class SingleRollScoringStrategy : IRollScoringStrategy
    {
        private int _die;
        private int _score;


        public SingleRollScoringStrategy(int die, int score)
        {
            _die = die;
            _score = score;
        }

        public int Score(Roll roll)
        {
            if (roll.Any(r => r == _die))
                return _score;

            return 0;

        }
    }

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