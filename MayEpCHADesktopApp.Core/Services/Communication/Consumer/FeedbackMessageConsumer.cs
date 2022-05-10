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
    public class FeedbackMessageConsumer : IConsumer<FeedbackMessage>
    {
        public async Task Consume(ConsumeContext<FeedbackMessage> context)
        {
            var message = context.Message;

          //  Console.WriteLine("Feedback: {0}", message.Mess);
        }
    }
}
