namespace StreetNameRegistry
{
    using System;
    using Autofac;
    using Be.Vlaanderen.Basisregisters.CommandHandling;
    using StreetName;

    public static class CommandHandlerModules
    {
        public static void Register(ContainerBuilder containerBuilder)
        {
            containerBuilder
                .RegisterType<StreetNameProvenanceFactory>()
                .SingleInstance();

            containerBuilder
                .RegisterType<StreetNameCommandHandlerModule>()
                .Named<CommandHandlerModule>(typeof(StreetNameCommandHandlerModule).FullName)
                .As<CommandHandlerModule>();
        }
    }
}
