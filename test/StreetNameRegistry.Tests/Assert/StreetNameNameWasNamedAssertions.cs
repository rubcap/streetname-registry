namespace StreetNameRegistry.Tests.Assert
{
    using FluentAssertions;
    using StreetName.Events;

    public class StreetNameNameWasNamedAssertions :
        HasStreetNameIdAssertions<StreetNameNameWasNamed, StreetNameNameWasNamedAssertions>
    {
        public StreetNameNameWasNamedAssertions(StreetNameNameWasNamed subject) : base(subject)
        {
        }

        public AndConstraint<StreetNameNameWasNamedAssertions> HaveName(string name)
        {
            AssertingThat($"the name is {name}");

            Subject.Name.Should().Be(name);

            return And();
        }

        public AndConstraint<StreetNameNameWasNamedAssertions> HaveLanguage(Language? language)
        {
            AssertingThat($"language is {language}");

            Subject.Language.Should().Be(language);

            return And();
        }
    }
}
