using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Warhammer.Common;
using WarhammerClient.Helpers;
using WarhammerClient.View.CharacterCreationPages;

namespace WarhammerClient.ViewModel
{
    public class CharacterCreationViewModel : BaseViewModel
    {
        public PlayerProfile PlayerProfile { get; set; }
        public CharacterCreationViewModel()
        {
            PlayerProfile = new PlayerProfile();

            Pages = new List<Page>();
            Pages.Add(new RaceSelectionPage() { DataContext = new RaceSelectionViewModel(PlayerProfile)});
            Pages.Add(new AttributesDrawPage());
            Pages.Add(new RaceAttributeDrawPage());

            CurrentPage = Pages.First();

            CancelCmd = new RelayCommand(CancelExe);
            PreviousPageCmd = new RelayCommand(PreviousPageExe, (x) => CanGoPrevious);
            NextPageCmd = new RelayCommand(NextPageExe, (x) => CanGoNext);
        }

        private bool CanGoPrevious => _pageIndex -1 >= 0;
        private bool CanGoNext => _pageIndex + 1 < Pages.Count;
        public ICommand CancelCmd { get; set; }
        public ICommand PreviousPageCmd { get; set; }
        public ICommand NextPageCmd { get; set; }

        private List<Page> Pages;
        private int _pageIndex = 0;

        private Page _currentPage;
        public Page CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;
                RaisePropertyChanged(nameof(CurrentPage));
            }
        }

        private void NextPageExe(object obj)
        {
            var p = Pages[++_pageIndex];
            p.DataContext = CreateDataContext(p);
            CurrentPage = p;
        }

        private void PreviousPageExe(object obj)
        {

            CurrentPage = Pages[--_pageIndex];
        }

        private object CreateDataContext(Page p)
        {
            if (p is RaceSelectionPage)
            {
                return new RaceSelectionViewModel(PlayerProfile);
            }

            if (p is AttributesDrawPage)
            {
                return new AttributeDrawViewModel(PlayerProfile);
            }

            if (p is RaceAttributeDrawPage)
            {
                return new RaceAttributeDrawViewModel(PlayerProfile);
            }

            Log.Error("Character craetion next datacontext not found.");
            return null;
        } 
        private void CancelExe(object obj)
        {
            if (obj is Window win)
                win.Close();
        }
    }
}
