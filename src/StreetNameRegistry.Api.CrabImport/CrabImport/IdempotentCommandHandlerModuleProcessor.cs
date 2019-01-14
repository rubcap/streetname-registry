namespace StreetNameRegistry.Api.CrabImport.CrabImport
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Be.Vlaanderen.Basisregisters.AggregateSource;
    using Be.Vlaanderen.Basisregisters.CommandHandling;
    using Be.Vlaanderen.Basisregisters.GrAr.Import.Api;
    using Autofac;
    using Be.Vlaanderen.Basisregisters.GrAr.Provenance;
    using StreetName;
    using StreetName.Commands;

    public class IdempotentCommandHandlerModuleProcessor : IIdempotentCommandHandlerModuleProcessor
    {
        private readonly ConcurrentUnitOfWork _concurrentUnitOfWork;
        private readonly StreetNameCommandHandlerModule _streetNameCommandHandlerModule;
        private readonly Func<IHasCrabProvenance, StreetName, Provenance> _provenanceFactory = new StreetNameProvenanceFactory().CreateFrom;
        private readonly Func<IStreetNames> _getStreetNames;

        public IdempotentCommandHandlerModuleProcessor(
            IComponentContext container,
            ConcurrentUnitOfWork concurrentUnitOfWork)
        {
            _concurrentUnitOfWork = concurrentUnitOfWork;
            _getStreetNames = container.Resolve<Func<IStreetNames>>();
            _streetNameCommandHandlerModule = new StreetNameCommandHandlerModule(_getStreetNames, () => concurrentUnitOfWork);
        }

        public async Task<CommandMessage> Process(
            dynamic commandToProcess,
            IDictionary<string, object> metadata,
            CancellationToken cancellationToken)
        {
            switch (commandToProcess)
            {
                case ImportStreetNameFromCrab command:
                    var commandImportStreetName = new CommandMessage<ImportStreetNameFromCrab>(command.CreateCommandId(), command, metadata);
                    await _streetNameCommandHandlerModule.ImportStreetNameFromCrab(_getStreetNames, commandImportStreetName, cancellationToken);
                    AddProvenancePipe.AddProvenance(() => _concurrentUnitOfWork, commandImportStreetName, _provenanceFactory);
                    return  commandImportStreetName;

                case ImportStreetNameStatusFromCrab command:
                    var commandImportStreetNameStatus = new CommandMessage<ImportStreetNameStatusFromCrab>(command.CreateCommandId(), command, metadata);
                    await _streetNameCommandHandlerModule.ImportStreetNameStatusFromCrab(_getStreetNames, commandImportStreetNameStatus, cancellationToken);
                    AddProvenancePipe.AddProvenance(() => _concurrentUnitOfWork, commandImportStreetNameStatus, _provenanceFactory);
                    return commandImportStreetNameStatus;

                default:
                    throw new NotImplementedException("Command to import is not recognized");
            }
        }
    }
}
