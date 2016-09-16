using NServiceBus;

namespace UserService.Messages.Commands
{
    /// <summary>
    /// The NServiceBus command to create a new user
    /// </summary>
    /// <remarks>
    /// <para>
    /// This class is an NServiceBus message. In response to some client sending this message, the consumer of this 
    /// message will create a new user.
    /// </para>
    /// <para>
    /// In the role of a message, this class forms the contract between the sender and the receiver of the message.
    /// </para>
    /// <para>
    /// In addition, this class plays the role of a _Data Transfer Object_.
    /// </para>
    /// </remarks>
    public class CreateNewUserCmd : ICommand
    {
        public string EmailAddress { get; set; }

        public string Name { get; set; }
    }
}
