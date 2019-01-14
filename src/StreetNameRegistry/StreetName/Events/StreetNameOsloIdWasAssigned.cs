namespace StreetNameRegistry.StreetName.Events
{
    using System;
    using Be.Vlaanderen.Basisregisters.EventHandling;
    using Newtonsoft.Json;
    using NodaTime;

    [EventName("StreetNameOsloIdWasAssigned")]
    [EventDescription("De straatnaam kreeg een Oslo Id toegekend.")]
    public class StreetNameOsloIdWasAssigned : IHasStreetNameId
    {
        public Guid StreetNameId { get; }
        public int OsloId { get; }
        public Instant AssignmentDate { get; }

        public StreetNameOsloIdWasAssigned(
            StreetNameId streetNameId,
            OsloId osloId,
            OsloAssignmentDate assignmentDate)
        {
            StreetNameId = streetNameId;
            OsloId = osloId;
            AssignmentDate = assignmentDate;
        }

        [JsonConstructor]
        private StreetNameOsloIdWasAssigned(
            Guid streetNameId,
            int osloId,
            Instant assignmentDate) :
            this(new StreetNameId(streetNameId),
                new OsloId(osloId),
                new OsloAssignmentDate(assignmentDate)) { }
    }
}
