using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer.Common
{
    public class AdvancedArmour
    {
        public ArmourType ArmourType { get; set; }
        /// <summary>
        /// obc
        /// </summary>
        public string Enc { get; set; }
        public string LocationsCovered { get; set; }
        /// <summary>
        /// PZ
        /// </summary>
        public string AP { get; set; }
    }
}
