namespace StreetNameRegistry.StreetName.Events.Crab
{
    using Be.Vlaanderen.Basisregisters.Crab;
    using Be.Vlaanderen.Basisregisters.EventHandling;
    using Newtonsoft.Json;
    using NodaTime;

    [EventName("StreetNameStatusWasImportedFromCrab")]
    [EventDescription("Legacy event om tblStraatnaamstatus en tblStraatnaamstatus_hist te importeren.")]
    public class StreetNameStatusWasImportedFromCrab : ICrabEvent, IHasCrabKey<int>
    {
        public int StreetNameStatusId { get; }
        public int StreetNameId { get; }
        public CrabStreetNameStatus StreetNameStatus { get; }
        public LocalDateTime? BeginDateTime { get; }
        public LocalDateTime? EndDateTime { get; }
        public Instant Timestamp { get; }
        public string Operator { get; }
        public CrabModification? Modification { get; }
        public CrabOrganisation? Organisation { get; }

        public int Key => StreetNameStatusId;

        public StreetNameStatusWasImportedFromCrab(
            CrabStreetNameStatusId streetNameStatusId,
            CrabStreetNameId streetNameId,
            CrabStreetNameStatus streetNameStatus,
            CrabLifetime lifetime,
            CrabTimestamp timestamp,
            CrabOperator @operator,
            CrabModification? modification,
            CrabOrganisation? organisation)
        {
            StreetNameStatusId = streetNameStatusId;
            StreetNameId = streetNameId;
            StreetNameStatus = streetNameStatus;
            BeginDateTime = lifetime.BeginDateTime;
            EndDateTime = lifetime.EndDateTime;
            Timestamp = timestamp;
            Operator = @operator;
            Modification = modification;
            Organisation = organisation;
        }

        [JsonConstructor]
        private StreetNameStatusWasImportedFromCrab(
            int streetNameStatusId,
            int streetNameId,
            CrabStreetNameStatus streetNameStatus,
            LocalDateTime? beginDateTime,
            LocalDateTime? endDateTime,
            Instant timestamp,
            string @operator,
            CrabModification? modification,
            CrabOrganisation? organisation) :
            this (
                  new CrabStreetNameStatusId(streetNameStatusId),
                  new CrabStreetNameId(streetNameId),
                  streetNameStatus,
                  new CrabLifetime(beginDateTime, endDateTime),
                  new CrabTimestamp(timestamp),
                  new CrabOperator(@operator),
                  modification,
                  organisation) { }
    }
}
