using NServiceBus;

namespace UserService.Messages.Commands
{
    /// <summary>
    /// Implements an NServiceBus command message to create a new user.
    /// </summary>
    public class CreateNewUserCmd : ICommand
    {
        public string EmailAddress { get; set; }

        public string Name { get; set; }
    }
}
