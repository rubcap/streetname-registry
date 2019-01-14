namespace StreetNameRegistry.Tests.Assert
{
    using StreetName.Events;

    public class StreetNamePrimaryLanguageWasClearedAssertions :
        HasStreetNameIdAssertions<StreetNamePrimaryLanguageWasCleared, StreetNamePrimaryLanguageWasClearedAssertions>
    {
        public StreetNamePrimaryLanguageWasClearedAssertions(StreetNamePrimaryLanguageWasCleared subject) : base(subject)
        {
        }
    }
}
