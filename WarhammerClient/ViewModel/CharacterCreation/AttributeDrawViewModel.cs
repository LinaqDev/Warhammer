using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warhammer.Common;

namespace WarhammerClient.ViewModel
{
    public class AttributeDrawViewModel : BaseViewModel
    {

        public AttributeDrawViewModel(PlayerProfile playerProfile)
        {
            playerProfile.SpecialFeatures = new SpecialFeatures();
            SpecialFeatures = playerProfile.SpecialFeatures;
                
            RollAttributes(playerProfile.Character.Race); 
        }

        private SpecialFeatures _specialFeatures;
        public SpecialFeatures SpecialFeatures
        {
            get => _specialFeatures;
            set
            {
                _specialFeatures = value;
                RaisePropertyChanged(nameof(SpecialFeatures));
            }
        }

        private void RollAttributes(Race race)
        {
            switch (race)
            {
                case Race.Human:
                    SpecialFeatures.InitialMain.WS = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.BS = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.S = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.T = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.AG = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.INT = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.WP = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.FEL = 20 + DiceService.Roll2k10();

                    SpecialFeatures.InitialSecondary.A = 1;
                    SpecialFeatures.InitialSecondary.W = DrawVitality(race);
                    SpecialFeatures.InitialSecondary.SB = SpecialFeatures.InitialMain.S / 10;
                    SpecialFeatures.InitialSecondary.TB = SpecialFeatures.InitialMain.T / 10;
                    SpecialFeatures.InitialSecondary.M = 4;
                    SpecialFeatures.InitialSecondary.MAG = 0;
                    SpecialFeatures.InitialSecondary.IP = 0;
                    SpecialFeatures.InitialSecondary.FP = DrawFP(race);
                    break;
                case Race.Dwarf:
                    SpecialFeatures.InitialMain.WS = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.BS = 30 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.S = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.T = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.AG = 30 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.INT = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.WP = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.FEL = 20 + DiceService.Roll2k10();

                    SpecialFeatures.InitialSecondary.A = 1;
                    SpecialFeatures.InitialSecondary.W = DrawVitality(race);
                    SpecialFeatures.InitialSecondary.SB = SpecialFeatures.InitialMain.S / 10;
                    SpecialFeatures.InitialSecondary.M =5;
                    SpecialFeatures.InitialSecondary.MAG = 0;
                    SpecialFeatures.InitialSecondary.IP = 0;
                    SpecialFeatures.InitialSecondary.FP = DrawFP(race);
                    break;
                case Race.Elf:
                    SpecialFeatures.InitialMain.WS = 30 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.BS = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.S = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.T = 30 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.AG = 10 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.INT = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.WP = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.FEL = 10 + DiceService.Roll2k10();

                    SpecialFeatures.InitialSecondary.A = 1;
                    SpecialFeatures.InitialSecondary.W = DrawVitality(race);
                    SpecialFeatures.InitialSecondary.SB = SpecialFeatures.InitialMain.S / 10;
                    SpecialFeatures.InitialSecondary.M = 3;
                    SpecialFeatures.InitialSecondary.MAG = 0;
                    SpecialFeatures.InitialSecondary.IP = 0;
                    break;
                case Race.Halfling:
                    SpecialFeatures.InitialMain.WS = 10 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.BS = 30 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.S = 10 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.T = 10 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.AG = 30 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.INT = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.WP = 20 + DiceService.Roll2k10();
                    SpecialFeatures.InitialMain.FEL = 30 + DiceService.Roll2k10();

                    SpecialFeatures.InitialSecondary.A = 1;
                    SpecialFeatures.InitialSecondary.W = DrawVitality(race);
                    SpecialFeatures.InitialSecondary.SB = SpecialFeatures.InitialMain.S / 10;
                    SpecialFeatures.InitialSecondary.M = 4;
                    SpecialFeatures.InitialSecondary.MAG = 0;
                    SpecialFeatures.InitialSecondary.IP = 0;
                    SpecialFeatures.InitialSecondary.FP = DrawFP(race);
                    break;
            }
        }

        private int DrawFP(Race race)
        {
            int i = DiceService.Roll10();
            switch (race)
            {
                case Race.Human:
                    if (i >= 1 && i <= 4)
                        return 2;
                    if (i >= 5 && i <= 7)
                        return 3;
                    if (i >= 8 && i <= 10)
                        return 3; 

                    break;
                case Race.Dwarf:
                    if (i >= 1 && i <= 4)
                        return 1;
                    if (i >= 5 && i <= 7)
                        return 2;
                    if (i >= 8 && i <= 10)
                        return 2;

                    break;
                case Race.Elf:
                    if (i >= 1 && i <= 4)
                        return 1;
                    if (i >= 5 && i <= 7)
                        return 2;
                    if (i >= 8 && i <= 10)
                        return 3;

                    break;
                case Race.Halfling:
                    if (i >= 1 && i <= 4)
                        return 2;
                    if (i >= 5 && i <= 7)
                        return 2;
                    if (i >= 8 && i <= 10)
                        return 2;

                    break;
            }

            Log.Warning("Vitality failed to FP.");
            return i;
        }

        private int DrawVitality(Race race)
        {
            int i = DiceService.Roll10();
            switch (race)
            {
                case Race.Human: 
                    if (i >= 1 && i <= 3)
                        return 10;
                    if (i >= 4 && i <= 6)
                        return 11;
                    if (i >= 7 && i <= 7)
                        return 12;
                    if (i == 10)
                        return 13;

                    break;
                case Race.Dwarf: 
                    if (i >= 1 && i <= 3)
                        return 9;
                    if (i >= 4 && i <= 6)
                        return 10;
                    if (i >= 7 && i <= 7)
                        return 11;
                    if (i == 10)
                        return 12;

                    break;
                case Race.Elf:
                    if (i >= 1 && i <= 3)
                        return 11;
                    if (i >= 4 && i <= 6)
                        return 12;
                    if (i >= 7 && i <= 7)
                        return 13;
                    if (i == 10)
                        return 14;

                    break;
                case Race.Halfling:
                    if (i >= 1 && i <= 3)
                        return 8;
                    if (i >= 4 && i <= 6)
                        return 9;
                    if (i >= 7 && i <= 7)
                        return 10;
                    if (i == 10)
                        return 11;
                    break;
            }

            Log.Warning("Vitality failed to draw.");
            return i;
        }
    }
}
