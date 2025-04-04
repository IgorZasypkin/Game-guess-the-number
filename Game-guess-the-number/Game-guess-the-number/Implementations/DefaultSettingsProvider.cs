using Game_guess_the_number.Interface;
using Game_guess_the_number.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_guess_the_number.Implementations
{
    public class DefaultSettingsProvider : IGameSettingsProvider
    {
        public GameSettings GetSettings()
        {
            return new GameSettings
            {
                MinNumber = 1,
                MaxNumber = 100,
                MaxAttempts = 7
            };
        }
    }
}
