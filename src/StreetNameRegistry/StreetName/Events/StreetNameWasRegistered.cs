namespace StreetNameRegistry.StreetName.Events
{
    using System;
    using Be.Vlaanderen.Basisregisters.EventHandling;
    using Be.Vlaanderen.Basisregisters.GrAr.Provenance;
    using Newtonsoft.Json;

    [EventName("StreetNameWasRegistered")]
    [EventDescription("De straatnaam werd geregistreerd.")]
    public class StreetNameWasRegistered : IHasProvenance, ISetProvenance
    {
        public Guid StreetNameId { get; }

        public Guid MunicipalityId { get; }
        public string NisCode { get; }
        public ProvenanceData Provenance { get; private set; }

        public StreetNameWasRegistered(
            StreetNameId streetNameId,
            MunicipalityId municipalityId,
            NisCode nisCode)
        {
            StreetNameId = streetNameId;
            MunicipalityId = municipalityId;
            NisCode = nisCode;
        }

        [JsonConstructor]
        private StreetNameWasRegistered(
            Guid streetNameId,
            Guid municipalityId,
            string nisCode,
            ProvenanceData provenance) :
            this(
                  new StreetNameId(streetNameId),
                  new MunicipalityId(municipalityId),
                  new NisCode(nisCode)) => ((ISetProvenance)this).SetProvenance(provenance.ToProvenance());

        void ISetProvenance.SetProvenance(Provenance provenance) => Provenance = new ProvenanceData(provenance);
    }
}
