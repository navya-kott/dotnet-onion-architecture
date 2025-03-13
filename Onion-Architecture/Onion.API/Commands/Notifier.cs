using MediatR;

namespace Onion.API.Commands
{
    public class Notifier:INotification
    {
        public string Message ;
        public Notifier(string message)
        {
            Message = message;
        }
    }
}
