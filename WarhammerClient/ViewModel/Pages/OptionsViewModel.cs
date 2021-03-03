using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WarhammerClient.Helpers;

namespace WarhammerClient.ViewModel
{
    public class OptionsViewModel:BaseViewModel
    {
        public OptionsViewModel()
        {
            SelectedLanguage = Properties.Settings.Default.Language;
            SaveCmd = new RelayCommand(SaveExe);
            CancelCmd = new RelayCommand(CancelExe);
        }

        public ICommand SaveCmd { get; set; }
        public ICommand CancelCmd { get; set; }
        public List<string> Languages { get; set; } = new List<string>() { "pl-PL", "en-US" };

        private string _selectedLanguage;
        public string SelectedLanguage
        {
            get => _selectedLanguage;
            set
            {
                _selectedLanguage = value;
                RaisePropertyChanged(nameof(SelectedLanguage));
                LanguageProvider.Instance.SetCulture(new CultureInfo(value));
            }
        }

        private void CancelExe(object obj)
        {
            SelectedLanguage = Properties.Settings.Default.Language; 
            if (obj is Window win)
                win.Close();
        }

        private void SaveExe(object obj)
        {
            Properties.Settings.Default.Language = SelectedLanguage;
            Properties.Settings.Default.Save();  
            if (obj is Window win)
                win.Close();
        }
    }
}
