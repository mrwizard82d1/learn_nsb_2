using NServiceBus;
using NServiceBus.Logging;
using UserService.Messages.Events;

namespace WelcomeEmailService
{
    internal class EmailSender : IHandleMessages<IUserCreatedEvent>
    {
        private static readonly ILog Log = LogManager.GetLogger<EmailSender>();

        public void Handle(IUserCreatedEvent message)
        {
            Log.InfoFormat("Sending welcome mail to {0}.", message.EmailAddress);
        }
    }
}
