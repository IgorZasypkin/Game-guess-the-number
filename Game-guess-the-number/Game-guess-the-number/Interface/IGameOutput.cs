using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_guess_the_number.Interface
{
    public interface IGameOutput
    {
        void WriteMessage(string message);
        void WritePrompt(string prompt);
    }
}
