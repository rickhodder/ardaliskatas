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

            return result;
        }
    }
}