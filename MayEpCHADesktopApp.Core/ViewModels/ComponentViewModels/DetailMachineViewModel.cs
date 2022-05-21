using ImmServiceContainers;
using MassTransit;
using MayEpCHADesktopApp.Core.Components;
using MayEpCHADesktopApp.Core.Model;
using MayEpCHADesktopApp.Core.Services.Communication.Consumer;
using MayEpCHADesktopApp.Core.Services.Interfaces;
using MayEpCHADesktopApp.Core.ViewModels.BaseViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace MayEpCHADesktopApp.Core.ViewModels.ComponentViewModels
{
    public class DetailMachineViewModel : ViewModels.BaseViewModels.BaseViewModel
    {

        #region var

  

        private  string content { get; set; }
        public  string Content { get => content; set { content = value; OnPropertyChanged(); } }
        private string tag { get; set; }
        public string Tag { get => tag; set { tag = value; OnPropertyChanged(); } }

        private bool animation1;
        public bool Animation1 { get => animation1; set { animation1 = value; OnPropertyChanged(); } }

        private bool animation2;
        public bool Animation2 { get => animation2; set { animation2 = value; OnPropertyChanged(); } }
        //so luong
        private string count { get; set; }
        public string Count { get => count; set { count = value; OnPropertyChanged(); } }



        //
        private string moldId { get; set; }
        public string MoldId { get => moldId; set { moldId = value; OnPropertyChanged(); } }


        //
        private string productId { get; set; }
        public string ProductId { get => productId; set { productId = value; OnPropertyChanged(); } }

        //
        private string cycle { get; set; }
        public string Cycle { get => cycle; set { cycle = value; OnPropertyChanged(); } }


        //
        private string cycleStandard { get; set; }
        public string CycleStandard { get => cycleStandard; set { cycleStandard = value; OnPropertyChanged(); } }

        //
        private string listEvent1 { get; set; }

        //
      
        
        private string mode;
 
        public string Mode { get => mode; set { mode = value; OnPropertyChanged(); } }

        //
        private bool a;
        public bool A { get => a; set { a = value; OnPropertyChanged(); } }
        private bool b;
        public bool B { get => b; set { b = value; OnPropertyChanged(); } }

        //


        //
        private string status;
        public string Status { get => status; set { status = value; OnPropertyChanged(); } }
        /// <summary>
        ///
        /// </summary>
        #endregion var
        private ObservableCollection<Product> listProduct;
        public ObservableCollection<Product> ListProduct
        {
            get => listProduct; set
            {
                listProduct = value; OnPropertyChanged();
            }
        }
        private ObservableCollection<Mold> listMold;
        public ObservableCollection<Mold> ListMold { get => listMold; set { listMold = value; } }
        private ObservableCollection<Employee> listEmployee;
        public ObservableCollection<Employee> ListEmployee { get => listEmployee; set { listEmployee = value; OnPropertyChanged(); } }
        private ObservableCollection<Machine> listMachine;
        public ObservableCollection<Machine> ListMachine { get => listMachine; set { listMachine = value; OnPropertyChanged(); } }
        public delegate void ReceiveCycleMessage(CycleMessage Message);
        public static ReceiveCycleMessage Sender;


        public delegate void ReceiveMachineMessage(MachineMessage Message);
        public static ReceiveMachineMessage MachineMessage;
        private Product product;
        public Product Product { get => product; set { product = value; OnPropertyChanged();
                try {
                    foreach (var item in ListMold)
                    {
                        if (Product.MoldId == item.Id)
                        {
                            Mold = item;
                            break;
                        }
                    }
                    
                    Cycle = Mold.StandardInjectionCycle.ToString();
                }catch (Exception ex)
                {

                }
            
            } }
        private Mold mold;
        public Mold Mold { get => mold; set { mold = value; OnPropertyChanged(); } }
        private IBusControl _bus;
        private IDatabaseServices _databaseServices;
        private IApiServices _apiServices;  
        public ICommand ChangeMoldCommand { get; set; }

        //IBusControl bus
        //IDatabaseServices databaseServices
        public DetailMachineViewModel(IBusControl bus, IDatabaseServices databaseServices, IApiServices apiServices) {
            _bus = bus;
            _databaseServices = databaseServices;
            _apiServices = apiServices;
            Content = "Tạm dừng";
            Animation1 = true;
            Animation2 = false;
            Sender = new ReceiveCycleMessage(GetCycleMessage);
            MachineMessage = new ReceiveMachineMessage(GetMachineStatus);
            ListMold = new ObservableCollection<Mold>();
            ListMachine = new ObservableCollection<Machine>();
            ListEmployee = new ObservableCollection<Employee>();
            GetTotalMold();
            GetTotalProduct();

            #region int
            Status = "1";
            A = true;
            B = false;
            Content = "Tạm dừng";

            #endregion int
            // _apiServices = apiServices;
            ChangeMoldCommand = new RelayObjectCommand<object>((p) => { return p == null ? false : true; }, async (p) => Pause(p));

        }
        public async  void Command(CommandMessage commandMessage)
        {
            var endpoint = await _bus.GetSendEndpoint(new Uri("http://127.0.0.1:8181/send-config"));
            await endpoint.Send<CommandMessage>(commandMessage);
        }
        public async  void ConfigCommand(ConfigurationMessage configMessage)
        {
            var endpoint = await _bus.GetSendEndpoint(new Uri("http://127.0.0.1:8181/send-config"));
            await endpoint.Send<ConfigurationMessage>(configMessage);
        }
        public void GetMachineStatus(MachineMessage Message)
        {

            switch (Message.MachineStatus)
            {
                case EMachineStatus.PowerOff:
                    Status = "1";
                    break;
                case EMachineStatus.PowerOn:
                    Status= "2";
                    break;
                case EMachineStatus.Disconnect:
                    Status = "3";
                    break;
                case EMachineStatus.OnProduction:
                    Status = "4";
                    break;
                case EMachineStatus.Idle:
                    Status = "5";
                    break;
                case EMachineStatus.ErrorOnGoing:
                    Status = "6";
                    break;
                case EMachineStatus.ErrorOutGoing:
                    Status = "7";
                    break;

            }

        }   
         public  void GetCycleMessage(CycleMessage Message)
        {


            Count = Message.CounterShot.ToString();
            ProductId = Message.ProductId.ToString();
            CycleStandard = Message.SetCycle.ToString();
            Cycle = Message.CycleTime.ToString();
            MoldId = Message.MoldId.ToString();
            if (Message.Mode == 1)
            {
                Mode = "Tự động";
            }
            else
            {
                Mode = "Bán Tự động";
            }
        }

        private void Pause(object p)
        {

            string Namemachine ="";
            if (p != null)
            {
                Namemachine = (p as UserControl).Tag.ToString();
            }
            else
            {
                Namemachine = "M24";
            }
            try
            {
              
                if( Content == "Tạm dừng")
                {
                   MessageBoxResult result = CustomMessageBox.Show("Bạn có chắc dừng lại thay khuôn không ??", "Cảnh báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                    if (result == MessageBoxResult.OK)
                    {
                        Content = "Tiếp tục";

                        Command(new CommandMessage
                        {
                            MachineId = Namemachine,
                            Timestamp = DateTime.UtcNow,
                            Command = ECommand.ChangeMold,

                        });
                        A = false;
                        B = true;
                        Content = "Tiếp tục";

                    }

                }
                else if (Content == "Tiếp tục")
                {
                    MessageBoxResult result = CustomMessageBox.Show("Bạn muốn máy hoạt động với thông số đã nhập??", "Cảnh báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                    if (result == MessageBoxResult.OK)
                    {

                        //ShiftReport shiftReport = new ShiftReport();
                        //shiftReport.MachineId = Namemachine;
                        //shiftReport.Date = DateTime.Now;
                        //if(DateTime.Now.Hour >7 && DateTime.Now.Minute < 19)
                        //{
                        //    shiftReport.TotalQuantity = (19 * 3600 - DateTime.Now.Hour * 60*60-DateTime.Now.Minute*60)/ Convert.ToInt32( Cycle );
                        //}

                        //shiftReport.ProductId = Product.Id;
                        //shiftReport.ShiftNumber = EShift.Night;
                        //_apiServices.PostShiftReportSingle("", shiftReport);
                        ConfigCommand(new ConfigurationMessage
                        {
                            MachineId = Namemachine,
                            Timestamp = DateTime.UtcNow,
                            MoldId = Mold.Id,
                            CycleTime = Convert.ToInt32(Cycle),
                            ProductId = Product.Id

                        }); ;
                        Command(new CommandMessage
                        {
                            MachineId = Namemachine,
                            Timestamp = DateTime.UtcNow,
                            Command = ECommand.ChangeMoldDone,

                        });

                        Content = "Tạm dừng";
                        A = true;
                        B = false;


                    }
                }
            }
            catch
            {

            }

        }
        ///api
    public async void GetTotalMold()
        {
            ListMold = await _apiServices.GetMoldTotal("");

    }
    public async void GetTotalProduct()
    {
        ListProduct = await _apiServices.GetProductTotal("");
    }


}
}
