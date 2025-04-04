using Game_guess_the_number.Interface;
using Game_guess_the_number.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_guess_the_number
{
    public class GameLogic
    {
        private readonly GameSettings _settings;
        private readonly INumberGenerator _generator;
        private readonly IUserInput _input;
        private readonly IGameOutput _output;

        private int _targetNumber;
        private int _currentAttempts;

        public GameLogic(
            GameSettings settings,
            INumberGenerator generator,
            IUserInput input,
            IGameOutput output)
        {
            _settings = settings;
            _generator = generator;
            _input = input;
            _output = output;
        }

        public void InitializeGame()
        {
            _targetNumber = _generator.Generate();
            _currentAttempts = 0;
            _output.WriteMessage($"Игра началась! Угадайте число от {_settings.MinNumber} до {_settings.MaxNumber}.");
            _output.WriteMessage($"У вас {_settings.MaxAttempts} попыток.");
        }

        public bool IsGameOver()
        {
            return _currentAttempts >= _settings.MaxAttempts;
        }

        public bool CheckGuess(int guess)
        {
            _currentAttempts++;

            if (guess == _targetNumber)
            {
                _output.WriteMessage($"Поздравляю! Вы угадали число за {_currentAttempts} попыток!");
                return true;
            }

            _output.WriteMessage(guess < _targetNumber ? "Больше!" : "Меньше!");
            _output.WriteMessage($"Осталось попыток: {_settings.MaxAttempts - _currentAttempts}");
            return false;
        }

        public int GetTargetNumber() => _targetNumber;
    }
}
