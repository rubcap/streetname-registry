namespace StreetNameRegistry.StreetName.Events
{
    using System;
    using Be.Vlaanderen.Basisregisters.EventHandling;
    using Newtonsoft.Json;
    using Be.Vlaanderen.Basisregisters.GrAr.Provenance;

    [EventName("StreetNameSecondaryLanguageWasCorrected")]
    [EventDescription("De straatnaam secundaire taal werd gecorrigeerd.")]
    public class StreetNameSecondaryLanguageWasCorrected : IHasStreetNameId, IHasProvenance, ISetProvenance
    {
        public Guid StreetNameId { get; }

        public Language SecondaryLanguage { get; }
        public ProvenanceData Provenance { get; private set; }

        public StreetNameSecondaryLanguageWasCorrected(
            StreetNameId streetNameId,
            Language secondaryLanguage)
        {
            StreetNameId = streetNameId;
            SecondaryLanguage = secondaryLanguage;
        }

        [JsonConstructor]
        private StreetNameSecondaryLanguageWasCorrected(
            Guid streetNameId,
            Language secondaryLanguage,
            ProvenanceData provenance) :
            this(
                new StreetNameId(streetNameId),
                secondaryLanguage) => ((ISetProvenance)this).SetProvenance(provenance.ToProvenance());

        void ISetProvenance.SetProvenance(Provenance provenance) => Provenance = new ProvenanceData(provenance);
    }
}
