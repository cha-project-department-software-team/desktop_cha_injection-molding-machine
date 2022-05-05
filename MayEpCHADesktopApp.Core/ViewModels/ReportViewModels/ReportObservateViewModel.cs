using MayEpCHADesktopApp.Core.Model;
using MayEpCHADesktopApp.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayEpCHADesktopApp.Core.ViewModels.ReportViewModels
{
  
    public class ReportObservateViewModel : ViewModels.BaseViewModels.BaseViewModel
    {
        private IApiServices _apiServices;
        private ObservableCollection<ShiftReport> listShiftReport;
        public ObservableCollection<ShiftReport> ListShiftReport { get => listShiftReport; set { listShiftReport = value; } }
        public ReportObservateViewModel(IApiServices apiService)
        {
            _apiServices = apiService;
            GetTotalShiftReport();
        }
        public async void GetTotalShiftReport()
        {
            ListShiftReport = new ObservableCollection<ShiftReport>();
            ListShiftReport = await _apiServices.GetShiftReportTotal("");
        }
    }
}
