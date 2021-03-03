using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer.Common
{
    public class PlayerProfile
    { 
        public Character Character { get; set; }
        public CharacterDetails CharacterDetails { get; set; }
        public Player Player { get; set; }
        public ExperiencePoints ExperiencePoints { get; set; }
        public CombatMovement  CombatMovement { get; set; }
        public SpecialFeatures SpecialFeatures { get; set; }
        public List<Weapon> Weapons { get; set; }
        public BasicArmour BasicArmour { get; set; }
        public List<AdvancedArmour> AdvancedArmours { get; set; }
        public ArmourPoints ArmourPoints { get; set; }
        public ActionSummary ActionSummary { get; set; }
        public List<Skill> BasicSkills { get; set; }
        public List<Skill> AdvancedSkills { get; set; }
        public List<Talent> Talents { get; set; }
        public List<EquipmentItem> Equipment { get; set; }
        public Money Money { get; set; }
    }
}
