using MediatR;

namespace Onion.API.Commands
{
    public class BlogCreateCommand:IRequest<bool>
    {
        public string Content;
        public string Publisher;

        public BlogCreateCommand(string content, string publisher)
        {
            Content = content;
            Publisher = publisher;
        }
    }
}
