namespace StreetNameRegistry.StreetName.Events
{
    using System;
    using Be.Vlaanderen.Basisregisters.EventHandling;
    using Newtonsoft.Json;
    using Be.Vlaanderen.Basisregisters.GrAr.Provenance;

    [EventName("StreetNameSecondaryLanguageWasCorrectedToCleared")]
    [EventDescription("De straatnaam secundaire taal werd gewist via correctie.")]
    public class StreetNameSecondaryLanguageWasCorrectedToCleared : IHasStreetNameId, IHasProvenance, ISetProvenance
    {
        public Guid StreetNameId { get; }
        public ProvenanceData Provenance { get; private set; }

        public StreetNameSecondaryLanguageWasCorrectedToCleared(StreetNameId streetNameId)
            => StreetNameId = streetNameId;

        [JsonConstructor]
        private StreetNameSecondaryLanguageWasCorrectedToCleared(
            Guid streetNameId,
            ProvenanceData provenance) :
            this(
                new StreetNameId(streetNameId)) => ((ISetProvenance)this).SetProvenance(provenance.ToProvenance());

        void ISetProvenance.SetProvenance(Provenance provenance) => Provenance = new ProvenanceData(provenance);
    }
}
