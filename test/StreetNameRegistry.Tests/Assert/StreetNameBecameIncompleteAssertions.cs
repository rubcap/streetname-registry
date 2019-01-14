namespace StreetNameRegistry.Tests.Assert
{
    using StreetName.Events;

    public static class StreetNameBecameIncompleteAssertionsProvider
    {
        public static StreetNameBecameIncompleteAssertions Should(this StreetNameBecameIncomplete subject)
        {
            return new StreetNameBecameIncompleteAssertions(subject);
        }
    }

    public class StreetNameBecameIncompleteAssertions :
        HasStreetNameIdAssertions<StreetNameBecameIncomplete, StreetNameBecameIncompleteAssertions>
    {
        public StreetNameBecameIncompleteAssertions(StreetNameBecameIncomplete subject) : base(subject)
        {
        }
    }
}

