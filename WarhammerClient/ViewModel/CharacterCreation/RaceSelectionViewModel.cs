using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Warhammer.Common;

namespace WarhammerClient.ViewModel
{
    public class RaceSelectionViewModel : BaseViewModel
    {
        private readonly PlayerProfile playerProfile;
        public RaceSelectionViewModel(PlayerProfile playerProfile)
        {
            this.playerProfile = playerProfile;
            this.playerProfile.Character = new Character();
        }

        public List<string> Races
        {
            get
            {
                return Enum.GetNames(typeof(Race)).ToList().Select(x=> LanguageProvider.Instance.GetValue(x)).ToList();
            }
        }
        
        
        private int _selectedRace= -1;
        public int SelectedRace
        {
            get => _selectedRace;
            set
            {
                _selectedRace = value;
                RaisePropertyChanged(nameof(SelectedRace));

                playerProfile.Character.Race = (Race)value;

                switch (value)
                {
                    case 0: //human 
                        RaceDescription = LanguageProvider.Instance.GetValue("DescriptionRaceHuman");
                        RaceHistory = $"Historia \n{LanguageProvider.Instance.GetValue("HistoryHuman")}";
                       
                        break;
                    case 1: //dwarf
                        RaceDescription = LanguageProvider.Instance.GetValue("DescriptionRaceDwarf");
                        RaceHistory = $"Historia \n{LanguageProvider.Instance.GetValue("HistoryDwarf")}";
                        break;
                    case 2: // elf
                        RaceDescription = LanguageProvider.Instance.GetValue("DescriptionRaceElf");
                        RaceHistory = $"Historia \n{LanguageProvider.Instance.GetValue("HistoryElf")}";
                        break;
                    case 3: // Halfling
                        RaceDescription = LanguageProvider.Instance.GetValue("DescriptionRaceHalfling");
                        RaceHistory = $"Historia \n{LanguageProvider.Instance.GetValue("HistoryHalfling")}";
                        break;
                    default:
                        RaceDescription = "";
                        RaceHistory = "";
                        break;

                }
            }
        }

        private string _raceDescription;
        public string RaceDescription
        {
            get => _raceDescription;
            set
            {
                _raceDescription = value;
                RaisePropertyChanged(nameof(RaceDescription));
            }
        }

        private string _raceHistory;
        public string RaceHistory
        {
            get => _raceHistory;
            set
            {
                _raceHistory = value;
                RaisePropertyChanged(nameof(RaceHistory));
            }
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged(nameof(Name));
                playerProfile.Character.Name = value;
            }
        }

    }
}
