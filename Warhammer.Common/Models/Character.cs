using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer.Common
{
    public class Character
    {
        public string Name { get; set; } 
        public Race Race { get; set; }
        public string CurrentCareer { get; set; }
        public string PreviousCareer { get; set; }
    }
}
