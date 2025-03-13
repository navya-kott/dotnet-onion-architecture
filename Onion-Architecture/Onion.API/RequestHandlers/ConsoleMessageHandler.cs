using MediatR;
using Onion.API.Commands;

namespace Onion.API.RequestHandlers
{
    public class ConsoleMessageHandler : INotificationHandler<Notifier>
    {
        public Task Handle(Notifier notification, CancellationToken cancellationToken)
        {
            Console.WriteLine(notification.Message.ToUpper());
            return Task.CompletedTask;
        }
    }
}
