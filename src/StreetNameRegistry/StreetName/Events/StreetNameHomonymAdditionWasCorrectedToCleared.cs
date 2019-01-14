namespace StreetNameRegistry.StreetName.Events
{
    using System;
    using Be.Vlaanderen.Basisregisters.EventHandling;
    using Newtonsoft.Json;
    using Be.Vlaanderen.Basisregisters.GrAr.Provenance;

    [EventName("StreetNameHomonymAdditionWasCorrectedToCleared")]
    [EventDescription("De straatnaam homoniem toevoeging werd gewist door correctie.")]
    public class StreetNameHomonymAdditionWasCorrectedToCleared : IHasStreetNameId, IHasProvenance, ISetProvenance
    {
        public Guid StreetNameId { get; }
        public Language? Language { get; }
        public ProvenanceData Provenance { get; private set; }

        public StreetNameHomonymAdditionWasCorrectedToCleared(
            StreetNameId streetNameId,
            Language? language)
        {
            StreetNameId = streetNameId;
            Language = language;
        }

        [JsonConstructor]
        private StreetNameHomonymAdditionWasCorrectedToCleared(
            Guid streetNameId,
            Language? language,
            ProvenanceData provenance) :
            this(
                  new StreetNameId(streetNameId),
                  language) => ((ISetProvenance)this).SetProvenance(provenance.ToProvenance());

        void ISetProvenance.SetProvenance(Provenance provenance) => Provenance = new ProvenanceData(provenance);
    }
}
