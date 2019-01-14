namespace StreetNameRegistry.StreetName.Events
{
    using System;
    using Be.Vlaanderen.Basisregisters.EventHandling;
    using Newtonsoft.Json;
    using Be.Vlaanderen.Basisregisters.GrAr.Provenance;

    [EventName("StreetNamePrimaryLanguageWasDefined")]
    [EventDescription("De straatnaam primaire taal werd gedefinieerd.")]
    public class StreetNamePrimaryLanguageWasDefined : IHasStreetNameId, IHasProvenance, ISetProvenance
    {
        public Guid StreetNameId { get; }

        public Language PrimaryLanguage { get; }
        public ProvenanceData Provenance { get; private set; }

        public StreetNamePrimaryLanguageWasDefined(
            StreetNameId streetNameId,
            Language primaryLanguage)
        {
            StreetNameId = streetNameId;
            PrimaryLanguage = primaryLanguage;
        }

        [JsonConstructor]
        private StreetNamePrimaryLanguageWasDefined(
            Guid streetNameId,
            Language primaryLanguage,
            ProvenanceData provenance) :
            this(
                new StreetNameId(streetNameId),
                primaryLanguage) => ((ISetProvenance)this).SetProvenance(provenance.ToProvenance());

        void ISetProvenance.SetProvenance(Provenance provenance) => Provenance = new ProvenanceData(provenance);
    }
}
