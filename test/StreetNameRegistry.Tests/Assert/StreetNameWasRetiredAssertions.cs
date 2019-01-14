namespace StreetNameRegistry.Tests.Assert
{
    using StreetName.Events;

    public class StreetNameWasRetiredAssertions :
        HasStreetNameIdAssertions<StreetNameWasRetired, StreetNameWasRetiredAssertions>
    {
        public StreetNameWasRetiredAssertions(StreetNameWasRetired subject) : base(subject)
        {
        }
    }

    public class StreetNameWasCorrectedToRetiredAssertions :
        HasStreetNameIdAssertions<StreetNameWasCorrectedToRetired, StreetNameWasCorrectedToRetiredAssertions>
    {
        public StreetNameWasCorrectedToRetiredAssertions(StreetNameWasCorrectedToRetired subject) : base(subject)
        {
        }
    }
}
