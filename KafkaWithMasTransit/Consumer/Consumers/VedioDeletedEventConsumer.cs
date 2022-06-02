using MassTransit;
using Producer.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consumer.Consumers
{
    public class VedioDeletedEventConsumer:IConsumer<VedioDeletedEvent>
    {
        public Task Consume(ConsumeContext<VedioDeletedEvent> context)
        {
            var message = context.Message.Title;
            return Task.CompletedTask;
        }
    }
}
