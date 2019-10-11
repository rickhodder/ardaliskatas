using System.Linq;

namespace Greed
{
    public class Game
    {
        public int Score(int[] roll)
        {
            var result = 0;

            if (roll.Any(r => r == 1))
                result+= 100;

            if (roll.Any(r => r == 5))
                result+= 50;

            if (roll.Count(r => r == 1)>=3)
                result += 1000;

            if (roll.Count(r => r == 2) >= 3)
                result += 200;

            return result;
        }
    }
}