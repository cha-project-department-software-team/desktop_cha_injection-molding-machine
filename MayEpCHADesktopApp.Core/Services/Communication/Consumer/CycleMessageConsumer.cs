using ImmServiceContainers;
using MassTransit;
using MayEpCHADesktopApp.Core.Store;
using MayEpCHADesktopApp.Core.ViewModels.ComponentViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayEpCHADesktopApp.Core.Services.Communication.Consumer
{
    public  class CycleMessageConsumer : IConsumer<CycleMessage>
    {
        //public CycleMessageConsumer(MQTTStore mQTTstore)
        //{

        //}
        public async Task Consume(ConsumeContext<CycleMessage> context)
        {
            var message = context.Message;
            DetailMachineViewModel.Sender(message);
          //  Console.WriteLine("Timestamp: {0}\r\nCycleTime: {1}\r\nOpenTime: {2}\r\nMode: {3}\r\nCounterShot: {4}\r\nMoldId: {5}\r\nSetCycle: {6}\r\n", message.Timestamp, message.CycleTime, message.OpenTime, message.Mode, message.CounterShot, message.MoldId, message.SetCycle);
        }

    }
}
