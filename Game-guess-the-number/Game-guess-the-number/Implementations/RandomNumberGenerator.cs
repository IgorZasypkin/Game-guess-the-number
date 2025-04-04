using Game_guess_the_number.Interface;
using Game_guess_the_number.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_guess_the_number.Implementations
{
    public class RandomNumberGenerator : INumberGenerator
    {
        private readonly GameSettings _settings;
        private readonly Random _random;

        public RandomNumberGenerator(GameSettings settings)
        {
            _settings = settings;
            _random = new Random();
        }

        public int Generate()
        {
            return _random.Next(_settings.MinNumber, _settings.MaxNumber + 1);
        }
    }
}
