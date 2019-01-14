namespace StreetNameRegistry.Tests.Assert
{
    using Be.Vlaanderen.Basisregisters.AggregateSource;
    using StreetName.Events;

    public static class AssertionsProvider
    {
        public static AggregateRootEntityAssertions Should(this AggregateRootEntity subject)
        {
            return new AggregateRootEntityAssertions(subject);
        }

        public static StreetNameStatusWasRemovedAssertions Should(this StreetNameStatusWasRemoved subject)
        {
            return new StreetNameStatusWasRemovedAssertions(subject);
        }

        public static StreetNameWasProposedAssertions Should(this StreetNameWasProposed subject)
        {
            return new StreetNameWasProposedAssertions(subject);
        }

        public static StreetNameWasRetiredAssertions Should(this StreetNameWasRetired subject)
        {
            return new StreetNameWasRetiredAssertions(subject);
        }

        public static StreetNameBecameCurrentAssertions Should(this StreetNameBecameCurrent subject)
        {
            return new StreetNameBecameCurrentAssertions(subject);
        }

        public static StreetNameStatusWasCorrectedToRemovedAssertions Should(this StreetNameStatusWasCorrectedToRemoved subject)
        {
            return new StreetNameStatusWasCorrectedToRemovedAssertions(subject);
        }

        public static StreetNameWasCorrectedToProposedAssertions Should(this StreetNameWasCorrectedToProposed subject)
        {
            return new StreetNameWasCorrectedToProposedAssertions(subject);
        }

        public static StreetNameWasCorrectedToCurrentAssertions Should(this StreetNameWasCorrectedToCurrent subject)
        {
            return new StreetNameWasCorrectedToCurrentAssertions(subject);
        }

        public static StreetNameWasCorrectedToRetiredAssertions Should(this StreetNameWasCorrectedToRetired subject)
        {
            return new StreetNameWasCorrectedToRetiredAssertions(subject);
        }

        public static StreetNameNameWasNamedAssertions Should(this StreetNameNameWasNamed subject)
        {
            return new StreetNameNameWasNamedAssertions(subject);
        }

        public static StreetNameHomonymAdditionWasDefinedAssertions Should(this StreetNameHomonymAdditionWasDefined subject)
        {
            return new StreetNameHomonymAdditionWasDefinedAssertions(subject);
        }

        public static StreetNameNameWasCorrectedAssertions Should(this StreetNameNameWasCorrected subject)
        {
            return new StreetNameNameWasCorrectedAssertions(subject);
        }

        public static StreetNameHomonymAdditionWasCorrectedAssertions Should(this StreetNameHomonymAdditionWasCorrected subject)
        {
            return new StreetNameHomonymAdditionWasCorrectedAssertions(subject);
        }

        public static StreetNamePrimaryLanguageWasDefinedAssertions Should(this StreetNamePrimaryLanguageWasDefined subject)
        {
            return new StreetNamePrimaryLanguageWasDefinedAssertions(subject);
        }

        public static StreetNamePrimaryLanguageWasCorrectedAssertions Should(this StreetNamePrimaryLanguageWasCorrected subject)
        {
            return new StreetNamePrimaryLanguageWasCorrectedAssertions(subject);
        }

        public static StreetNameSecondaryLanguageWasDefinedAssertions Should(this StreetNameSecondaryLanguageWasDefined subject)
        {
            return new StreetNameSecondaryLanguageWasDefinedAssertions(subject);
        }

        public static StreetNameSecondaryLanguageWasCorrectedAssertions Should(this StreetNameSecondaryLanguageWasCorrected subject)
        {
            return new StreetNameSecondaryLanguageWasCorrectedAssertions(subject);
        }

        public static StreetNameHomonymAdditionWasClearedAssertions Should(this StreetNameHomonymAdditionWasCleared subject)
        {
            return new StreetNameHomonymAdditionWasClearedAssertions(subject);
        }

        public static StreetNameNameWasClearedAssertions Should(this StreetNameNameWasCleared subject)
        {
            return new StreetNameNameWasClearedAssertions(subject);
        }

        public static StreetNameHomonymAdditionWasCorrectedToClearedAssertions Should(this StreetNameHomonymAdditionWasCorrectedToCleared subject)
        {
            return new StreetNameHomonymAdditionWasCorrectedToClearedAssertions(subject);
        }

        public static StreetNameNameWasCorrectedToClearedAssertions Should(this StreetNameNameWasCorrectedToCleared subject)
        {
            return new StreetNameNameWasCorrectedToClearedAssertions(subject);
        }

        public static StreetNamePrimaryLanguageWasClearedAssertions Should(this StreetNamePrimaryLanguageWasCleared subject)
        {
            return new StreetNamePrimaryLanguageWasClearedAssertions(subject);
        }

        public static StreetNamePrimaryLanguageWasCorrectedToClearedAssertions Should(this StreetNamePrimaryLanguageWasCorrectedToCleared subject)
        {
            return new StreetNamePrimaryLanguageWasCorrectedToClearedAssertions(subject);
        }

        public static StreetNameSecondaryLanguageWasClearedAssertions Should(this StreetNameSecondaryLanguageWasCleared subject)
        {
            return new StreetNameSecondaryLanguageWasClearedAssertions(subject);
        }

        public static StreetNameSecondaryLanguageWasCorrectedToClearedAssertions Should(this StreetNameSecondaryLanguageWasCorrectedToCleared subject)
        {
            return new StreetNameSecondaryLanguageWasCorrectedToClearedAssertions(subject);
        }
    }
}
