using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warhammer.Common;

namespace WarhammerClient.ViewModel
{
    public class CharacterPageViewModel:BaseViewModel
    {
        
        public CharacterPageViewModel()
        {
            LanguageProvider.CultureChanged += LanguageProvider_LanguageChanged;
        }

        private PlayerProfile _playerProfile;
        public PlayerProfile PlayerProfile
        {
            get => PlayerProfile;
            set
            {
                _playerProfile = value;
                RaisePropertyChanged(nameof(PlayerProfile));
            }
        }


        private void LanguageProvider_LanguageChanged(object sender, EventArgs e)
        {
            RaisePropertyChanged("");
        }
    }
}
