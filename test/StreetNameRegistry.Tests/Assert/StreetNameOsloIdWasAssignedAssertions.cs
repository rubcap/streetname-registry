namespace StreetNameRegistry.Tests.Assert
{
    using System;
    using FluentAssertions;
    using NodaTime;
    using StreetName.Events;

    public static class StreetNameOsloIdWasAssignedAssertionsProvider
    {
        public static StreetNameOsloIdWasAssignedAssertions Should(this StreetNameOsloIdWasAssigned subject)
        {
            return new StreetNameOsloIdWasAssignedAssertions(subject);
        }
    }

    public class StreetNameOsloIdWasAssignedAssertions :
        HasStreetNameIdAssertions<StreetNameOsloIdWasAssigned, StreetNameOsloIdWasAssignedAssertions>
    {
        public StreetNameOsloIdWasAssignedAssertions(StreetNameOsloIdWasAssigned subject) : base(subject)
        {
        }

        public AndConstraint<StreetNameOsloIdWasAssignedAssertions> HaveOsloId(int osloId)
        {
            AssertingThat($"has osloid {osloId}");

            Subject.OsloId.Should().Be(osloId);

            return And();
        }

        public AndConstraint<StreetNameOsloIdWasAssignedAssertions> HaveAssignmentDate(Instant date)
        {
            AssertingThat($"has assignment date is {date}");

            Subject.AssignmentDate.Should().Be(date);

            return And();
        }
    }
}
