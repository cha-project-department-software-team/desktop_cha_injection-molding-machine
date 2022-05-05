using MayEpCHADesktopApp.Core.Store;
using MayEpCHADesktopApp.Core.ViewModels.BaseViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MayEpCHADesktopApp.Core.ViewModels.ObservationViewModel
{
    public class ObservationMachineViewModel : ViewModels.BaseViewModels.BaseViewModel
    {
        private PageStore _store;
        public ICommand SwitchPage1 { get; set; }
        public ICommand SwitchPage2 { get; set; }
        public ICommand SwitchPage3 { get; set; }
        public ICommand SwitchPage4 { get; set; }
        public ICommand SwitchPage5 { get; set; }
        public ICommand SwitchPage6 { get; set; }
        public ICommand SwitchPage7 { get; set; }
        public event Action SwitchPageDetail;
        public ObservationMachineViewModel(PageStore _PageStore)
        {
            _store = _PageStore;
            SwitchPage1 = new RelayCommand(async () => await GoToPage1());
            SwitchPage2 = new RelayCommand(async () => await GoToPage2());
            SwitchPage3 = new RelayCommand(async () => await GoToPage3());
            SwitchPage4 = new RelayCommand(async () => await GoToPage4());
            SwitchPage5 = new RelayCommand(async () => await GoToPage5());
            SwitchPage6 = new RelayCommand(async () => await GoToPage6());
            SwitchPage7 = new RelayCommand(async () => await GoToPage7());
        }
        

        private void OnCurrentPageChanged()
        {
            SwitchPageDetail?.Invoke();
        }
        private Task GoToPage1()
        {
            _store.Page = 1;
            OnCurrentPageChanged();
            return Task.CompletedTask;
        }
        private Task GoToPage2()
        {
            
            _store.Page = 2;
            OnCurrentPageChanged();
            return Task.CompletedTask;
        }
        private Task GoToPage3()
        {
            
            _store.Page = 3;
            OnCurrentPageChanged();
            return Task.CompletedTask;
        }
        private Task GoToPage4()
        {
            
            _store.Page = 4;
            OnCurrentPageChanged();
            return Task.CompletedTask;
        }
        private Task GoToPage5()
        {
            
            _store.Page = 5;
            OnCurrentPageChanged();
            return Task.CompletedTask;
        }
        private Task GoToPage6()
        {
           
            _store.Page = 6;
            OnCurrentPageChanged();
            return Task.CompletedTask;
        }
        private Task GoToPage7()
        {
           
            _store.Page = 7;
            OnCurrentPageChanged();
            return Task.CompletedTask;
        }

    }
}
