using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warhammer.Common;

namespace WarhammerClient.ViewModel
{
    public class RaceAttributeDrawViewModel : BaseViewModel
    {
        public RaceAttributeDrawViewModel(PlayerProfile playerProfile)
        {
            playerProfile.BasicSkills = new List<Skill>();
            playerProfile.Talents = new List<Talent>();
        }

        private Talent DrawTalent(Race race)
        {
            var i = DiceService.Roll100();
            switch (race)
            {
                case Race.Human:
                    if (i >= 1 && i <= 4)
                        return TalentsCollection.GetTalentById(2);
                    if (i >= 5 && i <= 9)
                        return TalentsCollection.GetTalentById(2);
                    if (i >= 10 && i <= 13)
                        return TalentsCollection.GetTalentById(3);
                    if (i >= 14 && i <= 18)
                        return TalentsCollection.GetTalentById(4);
                    if (i >= 19 && i <= 22)
                        return TalentsCollection.GetTalentById(5);
                    if (i >= 23 && i <= 27)
                        return TalentsCollection.GetTalentById(6);
                    if (i >= 28 && i <= 31)
                        return TalentsCollection.GetTalentById(7);
                    if (i >= 32 && i <= 35)
                        return TalentsCollection.GetTalentById(8);
                    if (i >= 36 && i <= 40)
                        return TalentsCollection.GetTalentById(9);
                    if (i >= 41 && i <= 44)
                        return TalentsCollection.GetTalentById(10);
                    if (i >= 45 && i <= 49)
                        return TalentsCollection.GetTalentById(11);
                    if (i >= 50 && i <= 53)
                        return TalentsCollection.GetTalentById(12);
                    if (i >= 54 && i <= 57)
                        return TalentsCollection.GetTalentById(13);
                    if (i >= 58 && i <= 61)
                        return TalentsCollection.GetTalentById(14);
                    if (i >= 62 && i <= 66)
                        return TalentsCollection.GetTalentById(15);
                    if (i >= 67 && i <= 71)
                        return TalentsCollection.GetTalentById(16);
                    if (i >= 72 && i <= 75)
                        return TalentsCollection.GetTalentById(17);
                    if (i >= 76 && i <= 79)
                        return TalentsCollection.GetTalentById(18);
                    if (i >= 80 && i <= 83)
                        return TalentsCollection.GetTalentById(19);
                    if (i >= 84 && i <= 87)
                        return TalentsCollection.GetTalentById(20);
                    if (i >= 88 && i <= 91)
                        return TalentsCollection.GetTalentById(21);
                    if (i >= 92 && i <= 95)
                        return TalentsCollection.GetTalentById(22);
                    if (i >= 96 && i <= 100)
                        return TalentsCollection.GetTalentById(23);
                    break;
                case Race.Halfling:
                    if (i >= 1 && i <= 4)
                        return TalentsCollection.GetTalentById(1);
                    if (i >= 5 && i <= 9)
                        return TalentsCollection.GetTalentById(2);
                    if (i >= 10 && i <= 13)
                        return TalentsCollection.GetTalentById(3);
                    if (i >= 14 && i <= 18)
                        return TalentsCollection.GetTalentById(4);
                    if (i >= 19 && i <= 23)
                        return TalentsCollection.GetTalentById(5);
                    if (i >= 24 && i <= 28)
                        return TalentsCollection.GetTalentById(6);
                    if (i >= 29 && i <= 34)
                        return TalentsCollection.GetTalentById(7);
                    if (i >= 35 && i <= 39)
                        return TalentsCollection.GetTalentById(8);
                    if (i >= 40 && i <= 44)
                        return TalentsCollection.GetTalentById(9);
                    if (i >= 45 && i <= 49)
                        return TalentsCollection.GetTalentById(10);
                    if (i >= 50 && i <= 53)
                        return TalentsCollection.GetTalentById(11);
                    if (i >= 54 && i <= 58)
                        return TalentsCollection.GetTalentById(12);
                    if (i >= 59 && i <= 62)
                        return TalentsCollection.GetTalentById(13);
                    if (i >= 63 && i <= 64)
                        return TalentsCollection.GetTalentById(14);
                    if (i >= 65 && i <= 68)
                        return TalentsCollection.GetTalentById(15);
                    if (i >= 69 && i <= 73)
                        return TalentsCollection.GetTalentById(16);
                    if (i >= 74 && i <= 78)
                        return TalentsCollection.GetTalentById(17);
                    if (i >= 79 && i <= 82)
                        return TalentsCollection.GetTalentById(18);
                    if (i >= 83 && i <= 87)
                        return TalentsCollection.GetTalentById(19);
                    if (i >= 88 && i <= 92)
                        return TalentsCollection.GetTalentById(20);
                    if (i >= 93 && i <= 96)
                        return TalentsCollection.GetTalentById(21);
                    if (i >= 97 && i <= 100)
                        return TalentsCollection.GetTalentById(22);
                    break;
            }
            return null;
        }
    }
}
