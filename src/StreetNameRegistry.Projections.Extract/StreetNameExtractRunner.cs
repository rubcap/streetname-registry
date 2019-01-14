namespace StreetNameRegistry.Projections.Extract
{
    using Be.Vlaanderen.Basisregisters.ProjectionHandling.Runner;
    using Be.Vlaanderen.Basisregisters.ProjectionHandling.SqlStreamStore;
    using Be.Vlaanderen.Basisregisters.Shaperon;
    using Microsoft.Extensions.Logging;
    using StreetNameExtract;

    public class StreetNameExtractRunner : Runner<ExtractContext>
    {
        public const string Name = "StreetNameExtractRunner";

        public StreetNameExtractRunner(
            EnvelopeFactory envelopeFactory,
            ILogger<StreetNameExtractRunner> logger) :
            base(
                Name,
                envelopeFactory,
                logger,
                new StreetNameExtractProjections(DbaseCodePage.Western_European_ANSI.ToEncoding())) { }
    }
}
