using System.Linq;

namespace Greed
{
    public class Game
    {
        public int Score(int[] roll)
        {
            var result = 0;

            result += ScoreSingle( 1, roll, 100);

            result += ScoreSingle(5, roll, 50);

            result += ScoreMultiple(1, 3, roll, 1000);

            result += ScoreMultiple(2, 3, roll, 200);

            return result;
        }

        private static int ScoreSingle( int die, int[] roll, int score)
        {
            if (roll.Any(r => r == die))
                return score;

            return 0;
        }

        private static int ScoreMultiple(int die, int multiple, int[] roll, int score)
        {
            if (roll.Count(r => r == die) >= multiple)
                return score;

            return 0;
        }

    }
}