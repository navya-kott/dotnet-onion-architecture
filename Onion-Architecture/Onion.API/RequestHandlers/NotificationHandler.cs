using MediatR;
using Onion.API.Commands;

namespace Onion.API.RequestHandlers
{
    public class NotificationHandler : INotificationHandler<Notifier>
    {
        public Task Handle(Notifier notification, CancellationToken cancellationToken)
        {
            Console.WriteLine(notification.Message);
            return Task.CompletedTask;
        }
    }
}
