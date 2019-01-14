namespace StreetNameRegistry.Tests.Assert
{
    using StreetName.Events;

    public class StreetNameSecondaryLanguageWasClearedAssertions :
        HasStreetNameIdAssertions<StreetNameSecondaryLanguageWasCleared, StreetNameSecondaryLanguageWasClearedAssertions>
    {
        public StreetNameSecondaryLanguageWasClearedAssertions(StreetNameSecondaryLanguageWasCleared subject) : base(subject)
        {
        }
    }
}
