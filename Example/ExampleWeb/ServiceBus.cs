using NServiceBus;

namespace ExampleWeb
{
    public static class ServiceBus
    {
        public static IBus Bus { get; private set; }
        private static readonly object Padlock = new object();

        public static void Init()
        {
            if (Bus != null)
            {
                return;
            }
            lock (Padlock)
            {
                if (Bus != null)
                {
                    return; 
                }
                    
                var configuration = new BusConfiguration();
                configuration.UsePersistence<InMemoryPersistence>();
                configuration.UseTransport<RabbitMQTransport>();
                // Although used in the book source code, the following line is not strictly necessary. This class,
                // `ServiceBus` is in the namespace, `ExampleWeb`. The default behavior of NServiceBus is, for a
                // self-hosted endpoint (like this one), to create an endpoint with its name equal to the name of the
                // namespace of the class calling `NServiceBus.Bus.Create`.
                //
                // **HOWEVER**, this technique does not work with applications hosted with OWIN (Open Web Interface for
                // .NET). Consequently, NServiceBus 6.0 will **require** setting the endpoint name **explicitly**.
                // 
                // The book recommends that one start **explicitly** setting the `EndpointName` property so one is not
                // "surprised" by this change in default behavior.
                //
                configuration.EndpointName("ExampleWeb");
                configuration.PurgeOnStartup(true);
                configuration.EnableInstallers();
                configuration.UseSerialization<JsonSerializer>();

                Bus = NServiceBus.Bus.Create(configuration).Start();
            }
        }
    }
}