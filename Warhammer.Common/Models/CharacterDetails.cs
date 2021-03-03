using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer.Common
{
    public class CharacterDetails
    {
        public string Age { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
        public string StarSign { get; set; }
        public string BirthPlace { get; set; }
        public string DistinguishingMarks { get; set; }
        /// <summary>
        /// Male,Female
        /// </summary>
        public Gender Gender { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string NumberOfSiblings { get; set; }
    }
}
