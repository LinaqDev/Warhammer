using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer.Common
{
    public class SpecialFeatures
    {
        public SpecialFeatures()
        {
            InitialMain = new MainFeature();
            AdvancesMain = new MainFeature();
            CurrentMain = new MainFeature();

            InitialSecondary = new SecondaryFeature();
            AdvancesSecondary = new SecondaryFeature();
            CurrentSecondary = new SecondaryFeature();
        }
        public MainFeature InitialMain { get; set; }
        public MainFeature AdvancesMain { get; set; }
        public MainFeature CurrentMain { get; set; }

        public SecondaryFeature InitialSecondary { get; set; }
        public SecondaryFeature AdvancesSecondary { get; set; }
        public SecondaryFeature CurrentSecondary { get; set; } 
    }
}
