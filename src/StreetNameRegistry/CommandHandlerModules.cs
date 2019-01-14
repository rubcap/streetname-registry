namespace StreetNameRegistry
{
    using System;
    using Be.Vlaanderen.Basisregisters.AggregateSource;
    using Be.Vlaanderen.Basisregisters.CommandHandling.SqlStreamStore.Autofac;
    using Autofac;
    using StreetName;

    public static class CommandHandlerModules
    {
        public static void Register(ContainerBuilder containerBuilder)
        {
            containerBuilder
                .RegisterSqlStreamStoreCommandHandler<StreetNameCommandHandlerModule>(
                    c => handler =>
                        new StreetNameCommandHandlerModule(
                            c.Resolve<Func<IStreetNames>>(),
                            c.Resolve<Func<ConcurrentUnitOfWork>>(),
                            handler));
        }
    }
}
