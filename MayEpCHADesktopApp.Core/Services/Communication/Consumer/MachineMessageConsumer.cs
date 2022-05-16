using ImmServiceContainers;
using MassTransit;
using MayEpCHADesktopApp.Core.ViewModels.ComponentViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayEpCHADesktopApp.Core.Services.Communication.Consumer
{
    public class MachineMessageConsumer : IConsumer<MachineMessage>
    {
        public static event Action M1;
        public static event Action M2;
        public static event Action M3;
        public static event Action M4;
        public static event Action M5;
        public static event Action M6;
        public static event Action M7;
        public static event Action M8;
        public static event Action M9;
        public static event Action M10;
        public static event Action M11;
        public static event Action M12;
        public static event Action M13;
        public static event Action M14;
        public static event Action M15;
        public static event Action M16;
        public static event Action M17;
        public static event Action M18;
        public static event Action M19;
        public static event Action M20;
        public static event Action M21;
        public static event Action M22;
        public static event Action M23;
        public static event Action M24;
        public static event Action M25;
        public static event Action M26;
        public static event Action M27;
        public static event Action M28;
        public static event Action ML1;
        public static event Action ML2;
        public static event Action ML3;
        public static event Action ML4;
        public static event Action ML5;
        public static event Action ML6;
        public static event Action ML7;
        public static event Action ML8;
        public static event Action ML9;
        public static event Action ML10;
        public static event Action ML11;
        public static event Action ML12;


        public async Task Consume(ConsumeContext<MachineMessage> context)
        {
            var message = context.Message;
            MachineViewModel.Sender(message);
            DetailMachineViewModel.MachineMessage(message);
            

            Display(message);
            

        //    Console.WriteLine("MachineMessage: MachineId: {0}, Timestamp: {1}, MachineStatus: {2}", message.MachineId, message.Timestamp, message.MachineStatus);

        }
        private void Display(MachineMessage Message)
        {
            

            switch (Message.MachineId)
            {
                case "M1":
                    M1?.Invoke();
                    break;
                case "M2":
                    M2?.Invoke();
                    break;
                case "M3":
                    M3?.Invoke();
                    break;
                case "M4":
                    M4?.Invoke();
                    break;
                case "M5":
                    M5?.Invoke();
                    break;
                case "M6":
                    M6?.Invoke();
                    break;
                case "M7":
                    M7?.Invoke();
                    break;
                case "M8":
                    M8?.Invoke();
                    break;
                case "M9":
                    M9?.Invoke();
                    break;
                case "M10":
                    M10?.Invoke();
                    break;
                case "M11":
                    M11?.Invoke();
                    break;
                case "M12":
                    M12?.Invoke();
                    break;
                case "M13":
                    M13?.Invoke();
                    break;
                case "M14":
                    M14?.Invoke();
                    break;
                case "M15":
                    M15?.Invoke();
                    break;
                case "M16":
                    M16?.Invoke();
                    break;
                case "M17":
                    M17?.Invoke();

                    break;
                case "M18":
                    M1?.Invoke();
                    break;
                case "M19":
                    M19?.Invoke();
                    break;
                case "M20":
                    M20?.Invoke();
                    break;
                case "M21":
                    M21?.Invoke();
                    break;
                case "M22":
                    M22?.Invoke();
                    break;
                case "M23":
                    M23?.Invoke();
                    break;
                case "M24":
                    M24?.Invoke();
                    break;
                case "M25":
                    M25?.Invoke();
                    break;
                case "M26":
                    M26?.Invoke();
                    break;
                case "M27":
                    M27?.Invoke();
                    break;
                case "M28":
                    M28?.Invoke();
                    break;
                case "L1":
                    ML1?.Invoke();
                    break;
                case "L2":
                    ML1?.Invoke();
                    break;
                case "L3":
                    ML3?.Invoke();
                    break;
                case "L4":
                    ML4?.Invoke();
                    break;
                case "L5":
                    ML5?.Invoke();
                    break;
                case "L6":
                    ML6?.Invoke();
                    break;
                case "L7":
                    ML7?.Invoke();
                    break;
                case "L8":
                    ML8?.Invoke();
                    break;
                case "L9":
                    ML9?.Invoke();
                    break;
                case "L10":
                    ML10?.Invoke();
                    break;
                case "L11":
                    ML11?.Invoke();
                    break;
                case "L12":
                    ML12?.Invoke();
                    break;
                default:
                    break;
                    


            }
        }
    }
}
