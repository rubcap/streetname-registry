namespace StreetNameRegistry.Tests.Assert
{
    using StreetName.Events;

    public class StreetNameBecameCurrentAssertions :
        HasStreetNameIdAssertions<StreetNameBecameCurrent, StreetNameBecameCurrentAssertions>
    {
        public StreetNameBecameCurrentAssertions(StreetNameBecameCurrent subject) : base(subject)
        {
        }
    }
}
