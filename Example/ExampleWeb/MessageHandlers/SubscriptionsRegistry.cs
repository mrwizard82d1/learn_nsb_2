using ExampleWeb.Controllers;
using NServiceBus;
using NServiceBus.Logging;
using UserService.Messages.Events;

namespace ExampleWeb.MessageHandlers
{
    public class SubscriptionsRegistry : IHandleMessages<IUserCreatedEvent>
    {
        private static readonly ILog Log = LogManager.GetLogger<SubscriptionsRegistry>();

        public void Handle(IUserCreatedEvent message)
        {
            Log.InfoFormat("Adding subscriber Name={0}, Email={1}.", message.Name, message.EmailAddress);

            HomeController.Subscribers.Enqueue(message.EmailAddress);
        }
    }
}