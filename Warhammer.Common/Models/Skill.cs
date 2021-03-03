using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer.Common
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Taken { get; set; }
        public bool Plus10 { get; set; }
        public bool Plus20 { get; set; }
        public List<Talent> RelatedTalents { get; set; }
    }
}
