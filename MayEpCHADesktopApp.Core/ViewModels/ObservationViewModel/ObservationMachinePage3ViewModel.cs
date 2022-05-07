using MayEpCHADesktopApp.Core.ViewModels.ComponentViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayEpCHADesktopApp.Core.ViewModels.ObservationViewModel
{
    public class ObservationMachinePage3ViewModel : ViewModels.BaseViewModels.BaseViewModel
    {
        private DetailMachineViewModel _detailMachineViewModel1;
        public DetailMachineViewModel DetailMachineViewModel1
        {
            get => _detailMachineViewModel1; set
            {
                _detailMachineViewModel1 = value;
                OnPropertyChanged();
            }
        }
        private DetailMachineViewModel _detailMachineViewModel2;
        public DetailMachineViewModel DetailMachineViewModel2
        {
            get => _detailMachineViewModel2; set
            {
                _detailMachineViewModel2 = value;
                OnPropertyChanged();
            }
        }
        private DetailMachineViewModel _detailMachineViewModel3;
        public DetailMachineViewModel DetailMachineViewModel3
        {
            get => _detailMachineViewModel3; set
            {
                _detailMachineViewModel3 = value;
                OnPropertyChanged();
            }
        }
        private DetailMachineViewModel _detailMachineViewModel4;
        public DetailMachineViewModel DetailMachineViewModel4
        {
            get => _detailMachineViewModel4; set
            {
                _detailMachineViewModel4 = value;
                OnPropertyChanged();
            }
        }
        private DetailMachineViewModel _detailMachineViewModel5;
        public DetailMachineViewModel DetailMachineViewModel5
        {
            get => _detailMachineViewModel5; set
            {
                _detailMachineViewModel5 = value;
                OnPropertyChanged();
            }
        }
        private DetailMachineViewModel _detailMachineViewModel6;
        public DetailMachineViewModel DetailMachineViewModel6
        {
            get => _detailMachineViewModel6; set
            {
                _detailMachineViewModel6 = value;
                OnPropertyChanged();
            }
        }
        public ObservationMachinePage3ViewModel(DetailMachineViewModel detailMachineViewModel1,
                                                DetailMachineViewModel detailMachineViewModel2,
                                                DetailMachineViewModel detailMachineViewModel3,
                                                DetailMachineViewModel detailMachineViewModel4,
                                                DetailMachineViewModel detailMachineViewModel5,
                                                DetailMachineViewModel detailMachineViewModel6
            )
        {
            DetailMachineViewModel1 = detailMachineViewModel1;
            DetailMachineViewModel2 = detailMachineViewModel2;
            DetailMachineViewModel3 = detailMachineViewModel3;
            DetailMachineViewModel4 = detailMachineViewModel4;
            DetailMachineViewModel5 = detailMachineViewModel5;
            DetailMachineViewModel6 = detailMachineViewModel6;
        }

    }
}
