using ImmServiceContainers;
using MayEpCHADesktopApp.Core.Services.Communication.Consumer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MayEpCHADesktopApp.Core.ViewModels.ComponentViewModels
{

    public class MachineViewModel : ViewModels.BaseViewModels.BaseViewModel
    {

        //public string Count4 { get => count4; set { count4 = value; OnPropertyChanged(); } }
        //private string count5 { get; set; }
        public delegate void ReceiveCycleMessage(MachineMessage Message);
        public static ReceiveCycleMessage Sender;
        private CycleMessageConsumer cycleMessageConsumer;
        public string StatusTempt;
        public string Status { get => status; set { status = value; OnPropertyChanged(); } }
        private string status { get; set; }
        public static string Trangthai;

        public MachineViewModel()
        {
           /// Sender += ReiceveStatus;
            //Status = "7";
            
        }
        //public void ReiceverAction()
        //{
        //    if (StatusTempt != null )
        //    {
        //        Status = StatusTempt;
        //       // PreStatus = Trangthai;
        //        //switch (Status)
        //        //{
        //        //    case "1":
        //        //        StatusBackground1 = new SolidColorBrush(Colors.Red);
        //        //        break;
        //        //    case "2":
        //        //        StatusBackground1 = new SolidColorBrush(Colors.Green);
        //        //        break;
        //        //    case "3":
        //        //        StatusBackground1 = new SolidColorBrush(Colors.Yellow);
        //        //        break;
        //        //    case "4":
        //        //        StatusBackground1 = new SolidColorBrush(Colors.GreenYellow);
        //        //        break;
        //        //    case "5":
        //        //        StatusBackground1 = new SolidColorBrush(Colors.Orange);
        //        //        break;
        //        //    case "6":
        //        //        StatusBackground1 = new SolidColorBrush(Colors.Purple);
        //        //        break;
        //        //    case "7":
        //        //        StatusBackground1 = new SolidColorBrush(Colors.Gray);
        //        //        break;
        //        //}
        //    }


        //}

        public void ReiceverAction(MachineMessage machineMessage)
        {
            switch (machineMessage.MachineStatus)
            {
                case EMachineStatus.PowerOff:
                    Status = "1";
                    break;
                case EMachineStatus.PowerOn:
                    Status = "2";
                    break;
                case EMachineStatus.Disconnect:
                    Status = "3";
                    break;
                case EMachineStatus.Connected:
                    Status = "4";
                    break;
                case EMachineStatus.OnProduction:
                    Status = "5";
                    break;
                case EMachineStatus.Idle:
                    Status = "6";
                    break;
                case EMachineStatus.ErrorOnGoing:
                    Status = "7";
                    break;
                case EMachineStatus.ErrorOutGoing:
                    Status = "8";
                    break;

            }
        }


    }
}
