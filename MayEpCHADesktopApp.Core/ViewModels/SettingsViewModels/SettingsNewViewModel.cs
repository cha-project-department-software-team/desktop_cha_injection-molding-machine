using MayEpCHADesktopApp.Core.ViewModels.BaseViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MayEpCHADesktopApp.Core.ViewModels.SettingsViewModels
{
    public class SettingsNewViewModel : ViewModels.BaseViewModels.BaseViewModel
    {
        public bool IsShift1 { get => isShift1; set { isShift1 = value; OnPropertyChanged(); } }
        private bool isShift1;
        public bool IsShift2 { get => isShift2; set { isShift2 = value; OnPropertyChanged(); } }
        private bool isShift2;
        public ICommand Shift1 { set; get; }
        public ICommand Shift2 { set; get; }
        public SettingsNewViewModel()
        {
            Shift1 = new RelayCommand(async () => await GoToShift1());
            Shift2 = new RelayCommand(async () => await GoToShift2());
            IsShift1 = true;
            IsShift2 = false;
        }

        private Task GoToShift1()
        {
            IsShift1 = true;
            IsShift2 = false;
            return Task.CompletedTask;
        }
        private Task GoToShift2()
        {
            IsShift1 = false;
            IsShift2 = true;
            return Task.CompletedTask;
        }
    }
}
