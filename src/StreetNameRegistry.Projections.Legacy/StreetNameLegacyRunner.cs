namespace StreetNameRegistry.Projections.Legacy
{
    using Be.Vlaanderen.Basisregisters.ProjectionHandling.Runner;
    using Be.Vlaanderen.Basisregisters.ProjectionHandling.SqlStreamStore;
    using Microsoft.Extensions.Logging;
    using StreetNameDetail;
    using StreetNameList;
    using StreetNameName;
    using StreetNameSyndication;
    using StreetNameVersion;

    public class StreetNameLegacyRunner : Runner<LegacyContext>
    {
        public const string Name = "StreetNameLegacyRunner";

        public StreetNameLegacyRunner(EnvelopeFactory envelopeFactory, ILogger<StreetNameLegacyRunner> logger) :
            base(
                Name,
                envelopeFactory,
                logger,
                new StreetNameListProjections(),
                new StreetNameDetailProjections(),
                new StreetNameVersionProjections(),
                new StreetNameNameProjections(),
                new StreetNameSyndicationProjections()) { }
    }
}
