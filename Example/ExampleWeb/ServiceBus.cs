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
                configuration.EndpointName("ExampleWeb");
                configuration.PurgeOnStartup(true);
                configuration.EnableInstallers();

                Bus = NServiceBus.Bus.Create(configuration).Start();
            }
        }
    }
}