namespace StreetNameRegistry.Tests.Assert
{
    using StreetName.Events;

    public class StreetNameStatusWasRemovedAssertions :
        HasStreetNameIdAssertions<StreetNameStatusWasRemoved, StreetNameStatusWasRemovedAssertions>
    {
        public StreetNameStatusWasRemovedAssertions(StreetNameStatusWasRemoved subject) : base(subject)
        {
        }
    }

    public class StreetNameStatusWasCorrectedToRemovedAssertions :
        HasStreetNameIdAssertions<StreetNameStatusWasCorrectedToRemoved, StreetNameStatusWasCorrectedToRemovedAssertions>
    {
        public StreetNameStatusWasCorrectedToRemovedAssertions(StreetNameStatusWasCorrectedToRemoved subject) : base(subject)
        {
        }
    }
}
