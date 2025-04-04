using Game_guess_the_number.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_guess_the_number
{
    public class GuessNumberGame
    {
        private readonly GameLogic _logic;
        private readonly IUserInput _input;
        private readonly IGameOutput _output;

        public GuessNumberGame(GameLogic logic, IUserInput input, IGameOutput output)
        {
            _logic = logic;
            _input = input;
            _output = output;
        }

        public void Play()
        {
            _logic.InitializeGame();

            while (!_logic.IsGameOver())
            {
                try
                {
                    var guess = _input.GetUserGuess();
                    if (_logic.CheckGuess(guess))
                    {
                        return;
                    }
                }
                catch (FormatException)
                {
                    _output.WriteMessage("Ошибка: Введите целое число!");
                }
                catch (OverflowException)
                {
                    _output.WriteMessage("Ошибка: Число слишком большое или слишком маленькое!");
                }
            }

            _output.WriteMessage($"К сожалению, вы исчерпали все попытки. Загаданное число было: {_logic.GetTargetNumber()}");
        }
    }
}
