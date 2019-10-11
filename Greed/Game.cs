using System.Linq;

namespace Greed
{
    public class Game
    {
        public int Score(int[] roll)
        {
            if (roll.Any(r => r == 1))
                return 100;

            if (roll.Any(r => r == 5))
                return 50;

            return 0;
        }
    }
}