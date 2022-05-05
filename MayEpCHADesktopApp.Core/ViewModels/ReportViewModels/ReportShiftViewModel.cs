using MayEpCHADesktopApp.Core.Components;
using MayEpCHADesktopApp.Core.Model;
using MayEpCHADesktopApp.Core.Services.Interfaces;
using MayEpCHADesktopApp.Core.ViewModels.BaseViewModels;
using Microsoft.Win32;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MayEpCHADesktopApp.Core.ViewModels.ReportViewModels
{
  
    public class ReportShiftViewModel : ViewModels.BaseViewModels.BaseViewModel
    {
        //Biến tạo shiftreport
        private DateTime date;
        private int id;
        private EShift ShiftNumber;
        private int shift ;
        private Employee employee;
        private Machine machine;
        private Product product;
        private int totalQuantity;
        private DateTime startTime;
        private DateTime stopTime;
        private double workTime;
        private double pauseTime;
        private string note;
        private Mold mold;
        private int unit;
        private ShiftReport selectShiftReport;
        public DateTime Date { get => date; set { date = value; OnPropertyChanged(); } }
        public int Id { get => id; set { id = value;OnPropertyChanged(); } }
        public int Shift { get => shift; set { shift = value; OnPropertyChanged(); } }
        public Employee Employee { get => employee; set { employee = value; OnPropertyChanged(); } }
        public Machine Machine { get => machine; set { machine = value; OnPropertyChanged(); } }
        public Product Product { get => product; set { product = value; OnPropertyChanged();Unit = (Product.Unit == EUnit.Kilogram) ? 1 : 0; } }
        public int TotalQuantity { get => totalQuantity; set { totalQuantity = value; OnPropertyChanged(); } }
        public DateTime StartTime { get => startTime; set { startTime = value; OnPropertyChanged(); } }
        public DateTime StopTime { get => stopTime; set { stopTime = value; OnPropertyChanged(); } }
        public double WorkTime { get => workTime; set { workTime = value; OnPropertyChanged(); } }
        public double PauseTime { get => pauseTime; set { pauseTime = value; OnPropertyChanged(); } }
        public string Note { get => note; set { note = value; OnPropertyChanged(); } }
        public Mold Mold { get => mold; set { mold = value; OnPropertyChanged(); } }
        public int Unit { get => unit; set { unit = value; OnPropertyChanged(); } }
        public ShiftReport SelectShiftReport { get => selectShiftReport; 
                    set { 
                selectShiftReport = value;
                OnPropertyChanged();
               if (SelectShiftReport != null)
                {
                    
                    Date = SelectShiftReport.Date;
                    Shift = (SelectShiftReport.ShiftNumber == EShift.Night) ? 0 : 1;
                    Employee = SelectShiftReport.Employee;
                    Machine = SelectShiftReport.Machine;
                    Mold = SelectShiftReport.Product.Mold;
                    Product = SelectShiftReport.Product;
                    Unit = (SelectShiftReport.Product.Unit == EUnit.Kilogram) ? 0 : 1;
                    TotalQuantity = SelectShiftReport.TotalQuantity;
                    StartTime = SelectShiftReport.StartTime;
                    StopTime = SelectShiftReport.StopTime;
                    WorkTime = SelectShiftReport.WorkTime;
                    PauseTime = SelectShiftReport.PauseTime;
                    Note = SelectShiftReport.Note;
                }
               

                          
                        } }

        /// <summary>
        /// 
        /// </summary>
        private IApiServices _apiServices;
        private ObservableCollection<Product> listProduct;
        public ObservableCollection<Product> ListProduct { get => listProduct; set { listProduct = value; OnPropertyChanged();
            } }
        private ObservableCollection<Mold> listMold;
        public ObservableCollection<Mold> ListMold { get => listMold; set { listMold = value; } }
        private ObservableCollection<Employee> listEmployee;
        public ObservableCollection<Employee> ListEmployee { get => listEmployee; set { listEmployee = value; OnPropertyChanged(); } }
        private ObservableCollection<Machine> listMachine;
        public ObservableCollection<Machine> ListMachine { get => listMachine; set { listMachine = value; OnPropertyChanged(); } }
        private List<Shot> listShot;
        public ObservableCollection<ShiftReport> ListShiftReportTempt = new ObservableCollection<ShiftReport>();
        public List<Shot> ListShot { get => listShot; set { listShot = value; } }
        
        //
        public ICommand SaveExcelCommand { get; set; }
        public ICommand SaveDatagridCommand { get; set; }
        public ICommand ChangeCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        private ObservableCollection<ShiftReport> listShiftReport;
        public ObservableCollection<ShiftReport> ListShiftReport { get => listShiftReport; set { listShiftReport = value; } }
        public ReportShiftViewModel( IApiServices apiServices)
        {
            _apiServices = apiServices;
            SaveExcelCommand = new RelayCommand(async () => SaveExcel());
            SaveDatagridCommand = new RelayCommand(async () => SaveDatagrid());
            ChangeCommand = new RelayCommand(async () => ChangeShiftReport());
            DeleteCommand = new RelayCommand(async () => DeleteShiftReport());
            ListShiftReport = new ObservableCollection<ShiftReport>();
            ListShot = new List<Shot>();
            Shot shot = new Shot(DateTime.Now, 35, 10);
            ListShot.Add(shot);
            GetTotalEmplyee();
            GetTotalMold();
            GetTotalProduct();
            GetTotalMachinne();

        }
        private async void DeleteShiftReport()
        {

            // SelectShiftReport
          
                    MessageBoxResult result = CustomMessageBox.Show("Chỉnh sửa thành công", "Thông báo", System.Windows.MessageBoxButton.YesNo, System.Windows.MessageBoxImage.Asterisk);
                 //   if(result == MessageBoxResult.OK)
                //    {
                        ListShiftReport.Remove(SelectShiftReport);
                        OnPropertyChanged("ListShiftReport");
                   // }
                    
                
            
        }
        private async void ChangeShiftReport()
        {
            // SelectShiftReport

            SelectShiftReport.Date = Date;
            SelectShiftReport.ShiftNumber = (shift == 1) ? EShift.Night : EShift.Day;
            SelectShiftReport.EmployeeId = Employee.Id;
            SelectShiftReport.Employee = Employee;
            SelectShiftReport.ProductId = Product.Id;
            SelectShiftReport.Product = Product;
            SelectShiftReport.Product.Mold = Mold;
            SelectShiftReport.TotalQuantity = TotalQuantity;
            SelectShiftReport.StartTime = StartTime;
            SelectShiftReport.StopTime = StopTime;
            SelectShiftReport.WorkTime = WorkTime;
            SelectShiftReport.PauseTime = PauseTime;
            SelectShiftReport.Note = Note;
            SelectShiftReport.Shots = ListShot;
            SelectShiftReport.Machine = Machine;
            SelectShiftReport.MachineId = Machine.Id;
            CustomMessageBox.Show("Chỉnh sửa thành công", "Thông báo", System.Windows.MessageBoxButton.YesNo, System.Windows.MessageBoxImage.Asterisk);

        }
        private async void SaveDatagrid()
        {
            ShiftReport shiftReport = new ShiftReport();
            shiftReport.Date = Date;
            shiftReport.ShiftNumber = (shift == 1) ? EShift.Night : EShift.Day;
            shiftReport.EmployeeId = Employee.Id;
            shiftReport.Employee = Employee;
            shiftReport.ProductId = Product.Id;
            shiftReport.Product = Product;
            shiftReport.Product.Mold = Mold;
            shiftReport.TotalQuantity = TotalQuantity;
            shiftReport.StartTime = StartTime;
            shiftReport.StopTime = StopTime;
            shiftReport.WorkTime = WorkTime;
            shiftReport.PauseTime = PauseTime;
            shiftReport.Note = Note;
            shiftReport.Shots = ListShot;
            shiftReport.Machine = Machine;
            shiftReport.MachineId = Machine.Id;
            try
            {
                ListShiftReport.Add(shiftReport);
             //   CustomMessageBox.Show("Thêm thành công", "Thông báo", System.Windows.MessageBoxButton.YesNo, System.Windows.MessageBoxImage.Asterisk);
            }catch (Exception ex)
            {

            }
            



        }

        private async void SaveExcel()
        {

            //  _apiServices.PostShiftReport("", ListShiftReport);

            //string path = "C:/****/sample_data.xlsx";
            //FileInfo fileInfo = new FileInfo(path);

            //ExcelPackage package = new ExcelPackage(fileInfo);
            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            //  dialog.Filter = "Excel | *.xlsx | Excel 2016 | *.xls";
            
            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == true)
            {
                filePath = dialog.FileName;
            }
            try
            {
                using (ExcelPackage p = new ExcelPackage(new FileInfo(filePath)))
                {


                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[3];
                    
                    int rowIndex = 10;
                    while (ws.Cells["E" + rowIndex.ToString()].Value != null)
                    {
                        rowIndex++;
                    }
                    foreach(ShiftReport item in ListShiftReport)
                    {
                        ws.Cells["B" + rowIndex.ToString()].Value = item.Date.ToShortDateString();
                        ws.Cells["C" + rowIndex.ToString()].Value = (item.ShiftNumber == EShift.Night)?1:2;
                        ws.Cells["E" + rowIndex.ToString()].Value = item.Employee.Id;
                        ws.Cells["G" + rowIndex.ToString()].Value = item.Machine.Id;
                        ws.Cells["H" + rowIndex.ToString()].Value = item.Product.Mold.Id;
                        ws.Cells["K" + rowIndex.ToString()].Value = item.Product.Id;
                        if(item.Product.Unit == EUnit.Pieces)
                        {
                            ws.Cells["S" + rowIndex.ToString()].Value = item.TotalQuantity;
                        }
                        else
                        {
                            ws.Cells["S" + rowIndex.ToString()].Value = item.TotalQuantity;
                        }
                        ws.Cells["X" + rowIndex.ToString()].Value = item.StartTime;
                        ws.Cells["Y" + rowIndex.ToString()].Value = item.StopTime;
                        ws.Cells["AB" + rowIndex.ToString()].Value = item.Note;
                        ws.Cells["AA" + rowIndex.ToString()].Value = item.PauseTime;
                        rowIndex++;
                    }
                    // ws.Cells["E11"].Value = "pchung";
                    //Lưu file lại
                    
                    p.Save();
                    //   p.Dispose();


                }
                MessageBox.Show("Xuất excel thành công!");
            }
            catch (Exception EE)
            {
                MessageBox.Show("Có lỗi khi lưu file!");
            }

        }
        public async void GetTotalEmplyee()
        {
            ListEmployee = await _apiServices.GetEmployeeTotal("");
        }
        public async void GetTotalMold()
        {
            ListMold = await _apiServices.GetMoldTotal("");

        }
        public async void GetTotalProduct()
        {
            ListProduct = await _apiServices.GetProductTotal("");
        }
        public async void GetTotalMachinne()
        {
            ListMachine = await _apiServices.GetMachineTotal("");
        }
    }

}
