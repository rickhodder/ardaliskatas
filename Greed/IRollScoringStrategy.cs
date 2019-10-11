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
}