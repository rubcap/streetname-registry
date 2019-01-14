namespace StreetNameRegistry.Tests.AggregateTests
{
    using Assert;
    using Generate;
    using StreetName;
    using StreetName.Events;
    using Testing;
    using Xunit;
    using Xunit.Abstractions;

    public class AssignOsloIdFromCrabTests : TestBase
    {
        public AssignOsloIdFromCrabTests(ITestOutputHelper output) : base(output)
        {
        }

        protected StreetName RegisterWithId(StreetNameId streetNameId)
        {
            return StreetName.Register(streetNameId, new MunicipalityId(Arrange(Generate.CrabMunicipalityId).CreateDeterministicId()), Arrange(Generate.NisCode));
        }

        [Fact]
        public void AppliesOsloIdWasAssigned()
        {
            //Arrange
            var streetNameId = Arrange(Generate.StreetNameId);
            var sut = RegisterWithId(streetNameId);
            var date = Arrange(Produce.Instant());
            var osloId = Arrange(Produce.Integer(10000, 15000));

            //Act
            sut.AssignOsloId(new OsloId(osloId), new OsloAssignmentDate(date));

            //Assert
            sut.Should().HaveChanges();
            sut.Should().HaveSingleChange<StreetNameOsloIdWasAssigned>()
                .Which.Should().HaveStreetNameId(streetNameId)
                .And.HaveOsloId(osloId)
                .And.HaveAssignmentDate(date);
        }

        [Fact]
        public void AppliesOsloIdWhenAlreadyAssignedDoesNothing()
        {
            //Arrange
            var streetNameId = Arrange(Generate.StreetNameId);
            var sut = RegisterWithId(streetNameId);
            var osloId = Arrange(Produce.Integer(10000, 15000));
            var date = Arrange(Produce.Instant());

            sut.AssignOsloId(new OsloId(osloId), new OsloAssignmentDate(date));
            sut.ClearChanges();

            //Act
            sut.AssignOsloId(new OsloId(Arrange(Produce.Integer(10000, 15000))), new OsloAssignmentDate(date));

            //Assert
            sut.Should().HaveCountOfChanges<object>(0);
        }
    }
}
