using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer.Common
{
   public class ActionSummary
    {
        public List<Action> BasicActions { get; set; } = new List<Action>();
        public List<Action> AdvancedActions { get; set; } = new List<Action>();
    }
}
