using Game_guess_the_number.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_guess_the_number.Implementations
{
    public class ConsoleOutput : IGameOutput
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void WritePrompt(string prompt)
        {
            Console.Write(prompt);
        }
    }
}
