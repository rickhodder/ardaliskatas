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

            if (roll.Count(r => r == 1)>=3)
                result += 1000;

            if (roll.Count(r => r == 2) >= 3)
                result += 200;

            return result;
        }

        private static int ScoreSingle( int die, int[] roll, int score)
        {
            if (roll.Any(r => r == die))
                return score;

            return 0;
        }
    }
}