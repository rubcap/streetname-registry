namespace StreetNameRegistry.StreetName.Events
{
    using System;
    using Be.Vlaanderen.Basisregisters.EventHandling;
    using Newtonsoft.Json;
    using Be.Vlaanderen.Basisregisters.GrAr.Provenance;

    [EventName("StreetNameSecondaryLanguageWasDefined")]
    [EventDescription("De straatnaam secundaire taal werd gedefinieerd.")]
    public class StreetNameSecondaryLanguageWasDefined : IHasStreetNameId, IHasProvenance, ISetProvenance
    {
        public Guid StreetNameId { get; }

        public Language SecondaryLanguage { get; }
        public ProvenanceData Provenance { get; private set; }

        public StreetNameSecondaryLanguageWasDefined(
            StreetNameId streetNameId,
            Language secondaryLanguage)
        {
            StreetNameId = streetNameId;
            SecondaryLanguage = secondaryLanguage;
        }

        [JsonConstructor]
        private StreetNameSecondaryLanguageWasDefined(
            Guid streetNameId,
            Language secondaryLanguage,
            ProvenanceData provenance) :
            this(
                new StreetNameId(streetNameId),
                secondaryLanguage) => ((ISetProvenance)this).SetProvenance(provenance.ToProvenance());

        void ISetProvenance.SetProvenance(Provenance provenance) => Provenance = new ProvenanceData(provenance);
    }
}
