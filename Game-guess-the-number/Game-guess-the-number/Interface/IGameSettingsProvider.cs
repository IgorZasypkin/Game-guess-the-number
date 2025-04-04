﻿using Game_guess_the_number.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_guess_the_number.Interface
{
    public interface IGameSettingsProvider
    {
        GameSettings GetSettings();
    }
}
