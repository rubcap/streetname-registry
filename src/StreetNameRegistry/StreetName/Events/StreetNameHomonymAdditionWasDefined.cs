namespace StreetNameRegistry.StreetName.Events
{
    using System;
    using Be.Vlaanderen.Basisregisters.EventHandling;
    using Newtonsoft.Json;
    using Be.Vlaanderen.Basisregisters.GrAr.Provenance;

    [EventName("StreetNameHomonymAdditionWasDefined")]
    [EventDescription("De straatnaam homoniem toevoeging werd gedefinieerd.")]
    public class StreetNameHomonymAdditionWasDefined : IHasStreetNameId, IHasProvenance, ISetProvenance
    {
        public Guid StreetNameId { get; }

        public string HomonymAddition { get; }
        public Language? Language { get; }
        public ProvenanceData Provenance { get; private set; }

        public StreetNameHomonymAdditionWasDefined(
            StreetNameId streetNameId,
            StreetNameHomonymAddition homonymAddition)
        {
            StreetNameId = streetNameId;
            HomonymAddition = homonymAddition.HomonymAddition;
            Language = homonymAddition.Language;
        }

        [JsonConstructor]
        private StreetNameHomonymAdditionWasDefined(
            Guid streetNameId,
            string homonymAddition,
            Language? language,
            ProvenanceData provenance) :
            this(
                new StreetNameId(streetNameId),
                new StreetNameHomonymAddition(homonymAddition, language)) => ((ISetProvenance)this).SetProvenance(provenance.ToProvenance());

        void ISetProvenance.SetProvenance(Provenance provenance) => Provenance = new ProvenanceData(provenance);
    }
}
