using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer.Common
{
    public class Weapon
    {
        public string Name { get; set; }
        /// <summary>
        /// obc
        /// </summary>
        public string Enc { get; set; }
        /// <summary>
        /// Kategoria
        /// </summary>
        public string Group { get; set; }
        public string Damage { get; set; }
        public string Range { get; set; }
        public string Reload { get; set; }
        /// <summary>
        /// Cechy oręża
        /// </summary>
        public string Qualities { get; set; }
    }
}
