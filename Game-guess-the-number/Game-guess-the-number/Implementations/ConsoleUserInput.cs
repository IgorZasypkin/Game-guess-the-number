using Game_guess_the_number.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_guess_the_number.Implementations
{
    public class ConsoleUserInput : IUserInput
    {
        private readonly IGameOutput _output;

        public ConsoleUserInput(IGameOutput output)
        {
            _output = output;
        }

        public int GetUserGuess()
        {
            _output.WritePrompt("Введите вашу догадку: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
