namespace StreetNameRegistry.Projections.LastChangedList
{
    using Be.Vlaanderen.Basisregisters.ProjectionHandling.LastChangedList;
    using Be.Vlaanderen.Basisregisters.ProjectionHandling.SqlStreamStore;
    using Microsoft.Extensions.Logging;

    public class StreetNameLastChangedListRunner : LastChangedListRunner
    {
        public const string Name = "StreetNameLastChangedListRunner";

        public StreetNameLastChangedListRunner(
            EnvelopeFactory envelopeFactory,
            ILogger<StreetNameLastChangedListRunner> logger) :
            base(
                Name,
                new Projections(),
                envelopeFactory,
                logger)
        { }
    }
}
