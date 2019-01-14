namespace StreetNameRegistry.StreetName.Events.Crab
{
    using Be.Vlaanderen.Basisregisters.Crab;
    using Be.Vlaanderen.Basisregisters.EventHandling;
    using Newtonsoft.Json;
    using NodaTime;

    [EventName("StreetNameWasImportedFromCrab")]
    [EventDescription("Legacy event om tblStraatnaam en tblStraatnaam_hist te importeren.")]
    public class StreetNameWasImportedFromCrab
    {
        public int StreetNameId { get; }
        public int MunicipalityId { get; }
        public string PrimaryStreetName { get; }
        public string SecondaryStreetName { get; }
        public string PrimaryTransStreetName { get; }
        public string SecondaryTransStreetName { get; }
        public CrabLanguage? PrimaryLanguage { get; }
        public CrabLanguage? SecondaryLanguage { get; }
        public Instant Timestamp { get; set; }
        public LocalDateTime? BeginDateTime { get; }
        public LocalDateTime? EndDateTime { get; }
        public string Operator { get; }
        public CrabModification? Modification { get; }
        public CrabOrganisation? Organisation { get; }

        public StreetNameWasImportedFromCrab(
            CrabStreetNameId streetNameId,
            CrabMunicipalityId municipalityId,
            CrabStreetName primaryStreetName,
            CrabStreetName secondaryStreetName,
            CrabTransStreetName primaryTransStreetName,
            CrabTransStreetName secondaryTransStreetName,
            CrabLanguage? primaryLanguage,
            CrabLanguage? secondaryLanguage,
            CrabTimestamp timestamp,
            CrabLifetime lifetime,
            CrabOperator @operator,
            CrabModification? modification,
            CrabOrganisation? organisation)
        {
            StreetNameId = streetNameId;
            MunicipalityId = municipalityId;
            PrimaryStreetName = primaryStreetName?.Name;
            SecondaryStreetName = secondaryStreetName?.Name;
            PrimaryTransStreetName = primaryTransStreetName?.TransStreetName;
            SecondaryTransStreetName = secondaryTransStreetName?.TransStreetName;
            PrimaryLanguage = primaryLanguage;
            SecondaryLanguage = secondaryLanguage;
            Timestamp = timestamp;
            BeginDateTime = lifetime.BeginDateTime;
            EndDateTime = lifetime.EndDateTime;
            Operator = @operator;
            Modification = modification;
            Organisation = organisation;
        }

        [JsonConstructor]
        private StreetNameWasImportedFromCrab(
            int streetNameId,
            int municipalityId,
            string primaryStreetName,
            string secondaryStreetName,
            string primaryTransStreetName,
            string secondaryTransStreetName,
            CrabLanguage? primaryLanguage,
            CrabLanguage? secondaryLanguage,
            Instant timestamp,
            LocalDateTime? beginDateTime,
            LocalDateTime? endDateTime,
            string @operator,
            CrabModification? modification,
            CrabOrganisation? organisation) :
            this(
                new CrabStreetNameId(streetNameId),
                new CrabMunicipalityId(municipalityId),
                string.IsNullOrEmpty(primaryStreetName) ? null : new CrabStreetName(primaryStreetName, primaryLanguage),
                string.IsNullOrEmpty(secondaryStreetName) ? null : new CrabStreetName(secondaryStreetName, secondaryLanguage),
                string.IsNullOrEmpty(primaryTransStreetName) ? null : new CrabTransStreetName(primaryTransStreetName, primaryLanguage),
                string.IsNullOrEmpty(secondaryTransStreetName) ? null : new CrabTransStreetName(secondaryTransStreetName, secondaryLanguage),
                primaryLanguage,
                secondaryLanguage,
                new CrabTimestamp(timestamp),
                new CrabLifetime(beginDateTime, endDateTime),
                new CrabOperator(@operator),
                modification,
                organisation) { }
    }
}
