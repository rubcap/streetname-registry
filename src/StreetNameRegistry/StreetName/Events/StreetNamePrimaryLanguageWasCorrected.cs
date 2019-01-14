namespace StreetNameRegistry.StreetName.Events
{
    using System;
    using Be.Vlaanderen.Basisregisters.EventHandling;
    using Newtonsoft.Json;
    using Be.Vlaanderen.Basisregisters.GrAr.Provenance;

    [EventName("StreetNamePrimaryLanguageWasCorrected")]
    [EventDescription("De straatnaam primaire taal werd gecorrigeerd.")]
    public class StreetNamePrimaryLanguageWasCorrected : IHasStreetNameId, IHasProvenance, ISetProvenance
    {
        public Guid StreetNameId { get; }

        public Language PrimaryLanguage { get; }
        public ProvenanceData Provenance { get; private set; }

        public StreetNamePrimaryLanguageWasCorrected(
            StreetNameId streetNameId,
            Language primaryLanguage)
        {
            StreetNameId = streetNameId;
            PrimaryLanguage = primaryLanguage;
        }

        [JsonConstructor]
        private StreetNamePrimaryLanguageWasCorrected(
            Guid streetNameId,
            Language primaryLanguage,
            ProvenanceData provenance) :
            this(
                new StreetNameId(streetNameId),
                primaryLanguage) => ((ISetProvenance)this).SetProvenance(provenance.ToProvenance());

        void ISetProvenance.SetProvenance(Provenance provenance) => Provenance = new ProvenanceData(provenance);
    }
}
