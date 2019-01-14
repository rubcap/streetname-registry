namespace StreetNameRegistry.Tests.Assert
{
    using StreetName.Events;

    public class StreetNameWasProposedAssertions :
        HasStreetNameIdAssertions<StreetNameWasProposed, StreetNameWasProposedAssertions>
    {
        public StreetNameWasProposedAssertions(StreetNameWasProposed subject) : base(subject)
        {
        }
    }

    public class StreetNameWasCorrectedToProposedAssertions :
        HasStreetNameIdAssertions<StreetNameWasCorrectedToProposed, StreetNameWasCorrectedToProposedAssertions>
    {
        public StreetNameWasCorrectedToProposedAssertions(StreetNameWasCorrectedToProposed subject) : base(subject)
        {
        }
    }
}
