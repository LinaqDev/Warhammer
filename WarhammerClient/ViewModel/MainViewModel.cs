using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WarhammerClient.Helpers;
using WarhammerClient.View;
using WarhammerClient.View.Pages;

namespace WarhammerClient.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private CharacterPage _cachedCharacterPage;
        public MainViewModel()
        {
            OpenOptionsCmd = new RelayCommand(OpenOptionsExe);
            OpenCharacterPageCmd = new RelayCommand(OpenCharacterPageExe);
            OpenCaracterCreationCmd = new RelayCommand(OpenCaracterCreationExe);
            LanguageProvider.CultureChanged += LanguageProvider_LanguageChanged;
            LanguageProvider.Instance.SetCulture(new CultureInfo(Properties.Settings.Default.Language));
        }


        public ICommand OpenOptionsCmd { get; set; }
        public ICommand OpenCharacterPageCmd { get; set; }
        public ICommand OpenCaracterCreationCmd { get; set; }

        private Page _selectedPage = new Page();
        public Page SelectedPage
        {
            get
            {
                return _selectedPage;
            }
            set
            {
                if (value.Title != _selectedPage.Title)
                {
                    _selectedPage = value;
                    RaisePropertyChanged(nameof(SelectedPage));
                }
            }
        }

        private void OpenOptionsExe(object obj)
        {
            SelectedPage = new OptionsPage() { DataContext = new OptionsViewModel()};
        }
         
        private void OpenCharacterPageExe(object obj)
        {
            _cachedCharacterPage = _cachedCharacterPage == null ? new CharacterPage() { DataContext = new CharacterPageViewModel() } : _cachedCharacterPage;
            SelectedPage = _cachedCharacterPage;
        }


        private void OpenCaracterCreationExe(object obj)
        {
            var win = new CharacterCreationWindow() { DataContext = new CharacterCreationViewModel()};
            win.ShowDialog();
        }


        private void LanguageProvider_LanguageChanged(object sender, EventArgs e)
        {
            RaisePropertyChanged("");
        }
    }
}
