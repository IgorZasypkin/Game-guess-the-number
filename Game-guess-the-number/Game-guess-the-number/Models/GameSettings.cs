using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_guess_the_number.Models
{
    public class GameSettings
    {
        public int MinNumber { get; set; }
        public int MaxNumber { get; set; }
        public int MaxAttempts { get; set; }
    }
}
