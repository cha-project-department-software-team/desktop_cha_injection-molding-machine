using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MayEpCHADesktopApp.Core.ViewModels.ComponentViewModels;

namespace MayEpCHADesktopApp.Core.ViewModels.ObservationViewModel
{
    public class ObservationMachinePage7ViewModel : ViewModels.BaseViewModels.BaseViewModel
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
 
        public ObservationMachinePage7ViewModel(DetailMachineViewModel detailMachineViewModel1,
                                                DetailMachineViewModel detailMachineViewModel2,
                                                DetailMachineViewModel detailMachineViewModel3,
                                                DetailMachineViewModel detailMachineViewModel4
                                         
            )
        {
            DetailMachineViewModel1 = detailMachineViewModel1;
            DetailMachineViewModel2 = detailMachineViewModel2;
            DetailMachineViewModel3 = detailMachineViewModel3;
            DetailMachineViewModel4 = detailMachineViewModel4;

        }

    }
}
