namespace StreetNameRegistry.StreetName
{
    using Be.Vlaanderen.Basisregisters.AggregateSource;

    public interface IStreetNames : IAsyncRepository<StreetName, StreetNameId> { }
}
