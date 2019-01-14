namespace StreetNameRegistry.Tests.Testing
{
    using Be.Vlaanderen.Basisregisters.Crab;
    using Generate;
    using StreetName;
    using Xunit.Abstractions;

    public abstract class ImportStatusFromCrabTest : TestBase
    {
        protected ImportStatusFromCrabTest(ITestOutputHelper output) : base(output)
        {
        }

        protected StreetName RegisterWithId(StreetNameId streetNameId)
        {
            return StreetName.Register(streetNameId, new MunicipalityId(Arrange(Generate.CrabMunicipalityId).CreateDeterministicId()), Arrange(Generate.NisCode));
        }

        protected StreetName Act(StreetName sut, CrabStreetNameStatus status, CrabLifetime lifetime, CrabModification? modification, CrabStreetNameStatusId statusId = null)
        {
            LogAct($"ImportStatusFromCrab({status}, {lifetime}, {modification})");

            sut.ImportStatusFromCrab(statusId ?? Arrange(Generate.CrabStreetNameStatusId),
                Arrange(Generate.CrabStreetNameId),
                status,
                lifetime,
                Arrange(Generate.CrabTimestamp),
                Arrange(Generate.CrabOperator),
                modification,
                Arrange(Generate.CrabOrganisationNullable)
            );

            return sut;
        }

        protected StreetName EnsureStreetNameRemoved(StreetName sut)
        {
            var primaryLanguage = Arrange(Generate.CrabLanguageNullable);

            sut.ImportFromCrab(Arrange(Generate.CrabStreetNameId),
                Arrange(Generate.CrabMunicipalityId), Arrange(Generate.CrabStreetName), Arrange(Generate.CrabStreetName),
                Arrange(Generate.CrabTransStreetName), Arrange(Generate.CrabTransStreetName),
                primaryLanguage,
                Arrange(Generate.NullableEnumExcept(primaryLanguage)),
                Arrange(Generate.CrabLifetime),
                Arrange(Generate.CrabTimestamp),
                Arrange(Generate.CrabOperator), CrabModification.Delete, Arrange(Generate.CrabOrganisationNullable));

            return sut;
        }
    }
}
