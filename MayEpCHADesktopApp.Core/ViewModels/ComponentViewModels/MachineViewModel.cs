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
        public string PreStatus { get => preStatus; set { preStatus = value; OnPropertyChanged(); } }
        private string preStatus { get; set; }
        private SolidColorBrush statusBackground1;
        public SolidColorBrush StatusBackground1 { get => statusBackground1; set { statusBackground1 = value; OnPropertyChanged(); } }
        public static string Trangthai;

        public MachineViewModel()
        {
            Sender += ReiceveStatus;
            //Status = "7";
            
        }
        public void ReiceverAction()
        {
            if (StatusTempt != null )
            {
                Status = StatusTempt;
               // PreStatus = Trangthai;
                //switch (Status)
                //{
                //    case "1":
                //        StatusBackground1 = new SolidColorBrush(Colors.Red);
                //        break;
                //    case "2":
                //        StatusBackground1 = new SolidColorBrush(Colors.Green);
                //        break;
                //    case "3":
                //        StatusBackground1 = new SolidColorBrush(Colors.Yellow);
                //        break;
                //    case "4":
                //        StatusBackground1 = new SolidColorBrush(Colors.GreenYellow);
                //        break;
                //    case "5":
                //        StatusBackground1 = new SolidColorBrush(Colors.Orange);
                //        break;
                //    case "6":
                //        StatusBackground1 = new SolidColorBrush(Colors.Purple);
                //        break;
                //    case "7":
                //        StatusBackground1 = new SolidColorBrush(Colors.Gray);
                //        break;
                //}
            }


        }

        public void ReiceveStatus(MachineMessage machineMessage)
        {
            switch (machineMessage.MachineStatus)
            {
                case EMachineStatus.PowerOff:
                    StatusTempt = "1";
                    break;
                case EMachineStatus.PowerOn:
                    StatusTempt = "2";
                    break;
                case EMachineStatus.Disconnect:
                    StatusTempt = "3";
                    break;
                case EMachineStatus.OnProduction:
                    StatusTempt = "4";
                    break;
                case EMachineStatus.Idle:
                    StatusTempt = "5";
                    break;
                case EMachineStatus.ErrorOnGoing:
                    StatusTempt = "6";
                    break;
                case EMachineStatus.ErrorOutGoing:
                    StatusTempt = "7";
                    break;

            }
        }


    }
}
