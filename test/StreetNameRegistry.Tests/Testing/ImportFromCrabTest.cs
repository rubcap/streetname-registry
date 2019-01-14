namespace StreetNameRegistry.Tests.Testing
{
    using Be.Vlaanderen.Basisregisters.Crab;
    using Generate;
    using StreetName;
    using Xunit.Abstractions;

    public abstract class ImportFromCrabTest : TestBase
    {
        protected StreetName RegisterWithId(StreetNameId streetNameId)
        {
            return StreetName.Register(streetNameId, new MunicipalityId(Arrange(Generate.CrabMunicipalityId).CreateDeterministicId()), Arrange(Generate.NisCode));
        }

        protected StreetName Act(StreetName sut, CrabModification modification)
        {
            return Act(sut, Arrange(Generate.CrabLifetime), modification);
        }

        protected StreetName Act(StreetName sut, CrabLifetime lifetime, CrabModification? modification)
        {
            return Act(sut, Arrange(Generate.CrabStreetName), Arrange(Generate.CrabStreetName), lifetime, modification);
        }

        protected StreetName Act(StreetName sut, CrabStreetName primaryStreetName, CrabStreetName secondaryStreetName, CrabLifetime lifetime, CrabModification? modification)
        {
            var primaryLanguage = Arrange(Generate.CrabLanguageNullable);

            return Act(sut, Arrange(Generate.CrabStreetNameId),
                Arrange(Generate.CrabMunicipalityId),
                primaryStreetName,
                secondaryStreetName,
                Arrange(Generate.CrabTransStreetName),
                Arrange(Generate.CrabTransStreetName),
                primaryLanguage,
                Arrange(Generate.NullableEnumExcept(primaryLanguage)),
                lifetime,
                Arrange(Generate.CrabTimestamp),
                Arrange(Generate.CrabOperator), modification, Arrange(Generate.CrabOrganisationNullable));
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

        protected StreetName Act(StreetName sut,
            CrabStreetNameId CrabStreetNameId,
            CrabMunicipalityId crabMunicipalityId,
            CrabStreetName primaryStreetName,
            CrabStreetName secondaryStreetName,
            CrabTransStreetName primaryTransStreetName,
            CrabTransStreetName secondaryTransStreetName,
            CrabLanguage? primaryLanguage,
            CrabLanguage? secondaryLanguage,
            CrabLifetime lifetime,
            CrabTimestamp crabTimestamp,
            CrabOperator beginOperator,
            CrabModification? modification,
            CrabOrganisation? beginOrganisation)
        {
            LogAct($"ImportFromCrab({CrabStreetNameId},{crabMunicipalityId},{primaryStreetName},{secondaryStreetName},{secondaryTransStreetName},{primaryTransStreetName},{primaryLanguage},{secondaryLanguage},{lifetime},{crabTimestamp},{beginOperator},{modification},{beginOrganisation})");

            sut.ImportFromCrab(CrabStreetNameId,
                crabMunicipalityId,
                primaryStreetName,
                secondaryStreetName,
                primaryTransStreetName,
                secondaryTransStreetName,
                primaryLanguage,
                secondaryLanguage,
                lifetime,
                crabTimestamp,
                beginOperator,
                modification,
                beginOrganisation);

            return sut;
        }

        protected StreetName Act(StreetName sut, CrabLanguage? primaryLanguage, CrabLanguage? secondaryLanguage, CrabLifetime lifetime, CrabModification? modification)
        {
            return Act(sut,
                Arrange(Generate.CrabStreetNameId),
                Arrange(Generate.CrabMunicipalityId),
                Arrange(Generate.CrabStreetName),
                Arrange(Generate.CrabStreetName),
                Arrange(Generate.CrabTransStreetName),
                Arrange(Generate.CrabTransStreetName),
                primaryLanguage,
                secondaryLanguage,
                lifetime,
                Arrange(Generate.CrabTimestamp),
                Arrange(Generate.CrabOperator),
                modification,
                Arrange(Generate.CrabOrganisationNullable));
        }

        protected ImportFromCrabTest(ITestOutputHelper output) : base(output)
        {
        }
    }
}
