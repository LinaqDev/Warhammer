using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerClient
{
    public static class DiceService
    {
        private static Random rand = new Random();

        public static int Roll2k10()
        {
           return rand.Next(1, 10) + rand.Next(1, 10);
        }

        public static int Roll10()
        {
            return rand.Next(1, 10);
        }
        public static int Roll100()
        {
            return rand.Next(1, 100);
        }
    }
}
