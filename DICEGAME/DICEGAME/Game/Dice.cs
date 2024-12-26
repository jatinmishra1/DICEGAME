

namespace DICEGAME.Game
{
    public class Dice
    {
        private readonly Random _random;
        private readonly int _sidesCount;

        public Dice(Random random, int sidesCount)
        {
            _sidesCount = sidesCount;
            _random = random;

        }

        public int Roll() => _random.Next(1, _sidesCount + 1);

    }
}
