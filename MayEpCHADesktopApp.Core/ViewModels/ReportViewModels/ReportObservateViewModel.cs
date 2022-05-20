using MayEpCHADesktopApp.Core.Components;
using MayEpCHADesktopApp.Core.Model;
using MayEpCHADesktopApp.Core.Services.Interfaces;
using MayEpCHADesktopApp.Core.ViewModels.BaseViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace MayEpCHADesktopApp.Core.ViewModels.ReportViewModels
{
  
    public class ReportObservateViewModel : ViewModels.BaseViewModels.BaseViewModel
    {
        private IApiServices _apiServices;
        private ObservableCollection<ShiftReport> listShiftReport;
        public ObservableCollection<ShiftReport> ListShiftReport { get => listShiftReport; set { listShiftReport = value; } }
        
        public ICommand LoadChartCommand { get; set; }
        public ReportObservateViewModel(IApiServices apiService)
        {
            _apiServices = apiService;
            GetTotalShiftReport();
            LoadChartCommand = new RelayObjectCommand<StackPanel>((p) => { return p == null ? false : true; }, async (p) => LoadChart(p));
        }
        public async void LoadChart(StackPanel p)
        {
            
            ChartObservationEmployee  chart = new ChartObservationEmployee();
            //p.Children.Add(chart);
            //p.Children.Add(chart);
            //p.Children.Add(chart);
        }
        public async void GetTotalShiftReport()
        {
            ListShiftReport = new ObservableCollection<ShiftReport>();
            ListShiftReport = await _apiServices.GetShiftReportTotal("");
        }
    }
}
