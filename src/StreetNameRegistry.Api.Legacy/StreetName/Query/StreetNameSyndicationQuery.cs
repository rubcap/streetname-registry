namespace StreetNameRegistry.Api.Legacy.StreetName.Query
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Be.Vlaanderen.Basisregisters.Api.Search;
    using Be.Vlaanderen.Basisregisters.Api.Search.Filtering;
    using Be.Vlaanderen.Basisregisters.Api.Search.Sorting;
    using Be.Vlaanderen.Basisregisters.GrAr.Provenance;
    using Microsoft.EntityFrameworkCore;
    using NodaTime;
    using Projections.Legacy;
    using Projections.Legacy.StreetNameSyndication;

    public class StreetNameSyndicationQueryResult
    {
        public bool ContainsDetails { get; }

        public Guid? StreetNameId { get; }
        public long Position { get; }
        public string ChangeType { get; }
        public int? OsloId { get; }
        public string NisCode { get; }
        public Instant RecordCreatedAt { get; }
        public Instant LastChangedOn { get; }
        public StreetNameStatus? Status { get; }
        public string NameDutch { get; }
        public string NameFrench { get; }
        public string NameGerman { get; }
        public string NameEnglish { get; }
        public string HomonymAdditionDutch { get; }
        public string HomonymAdditionFrench { get; }
        public string HomonymAdditionGerman { get; }
        public string HomonymAdditionEnglish { get; }
        public bool IsComplete { get; }
        public Organisation? Organisation { get; }
        public Plan? Plan { get; }

        public StreetNameSyndicationQueryResult(
            Guid? streetNameId,
            long position,
            int? osloId,
            string nisCode,
            string changeType,
            Instant recordCreatedAt,
            Instant lastChangedOn,
            bool isComplete,
            Organisation? organisation,
            Plan? plan)
        {
            ContainsDetails = false;

            StreetNameId = streetNameId;
            Position = position;
            OsloId = osloId;
            NisCode = nisCode;
            ChangeType = changeType;
            RecordCreatedAt = recordCreatedAt;
            LastChangedOn = lastChangedOn;
            IsComplete = isComplete;
            Organisation = organisation;
            Plan = plan;
        }

        public StreetNameSyndicationQueryResult(
            Guid? streetNameId,
            long position,
            int? osloId,
            string nisCode,
            string changeType,
            Instant recordCreatedAt,
            Instant lastChangedOn,
            StreetNameStatus? status,
            string nameDutch,
            string nameFrench,
            string nameGerman,
            string nameEnglish,
            string homonymAdditionDutch,
            string homonymAdditionFrench,
            string homonymAdditionGerman,
            string homonymAdditionEnglish,
            bool isComplete,
            Organisation? organisation,
            Plan? plan) :
            this(
                streetNameId,
                position,
                osloId,
                nisCode,
                changeType,
                recordCreatedAt,
                lastChangedOn,
                isComplete,
                organisation,
                plan)
        {
            ContainsDetails = true;

            Status = status;
            NameDutch = nameDutch;
            NameFrench = nameFrench;
            NameGerman = nameGerman;
            NameEnglish = nameEnglish;
            HomonymAdditionDutch = homonymAdditionDutch;
            HomonymAdditionFrench = homonymAdditionFrench;
            HomonymAdditionGerman = homonymAdditionGerman;
            HomonymAdditionEnglish = homonymAdditionEnglish;
        }
    }

    public class StreetNameSyndicationQuery : Query<StreetNameSyndicationItem, StreetNameSyndicationFilter, StreetNameSyndicationQueryResult>
    {
        private readonly LegacyContext _context;
        private readonly bool _embed;

        public StreetNameSyndicationQuery(LegacyContext context, bool embed)
        {
            _context = context;
            _embed = embed;
        }

        protected override ISorting Sorting => new StreetNameSyndicationSorting();

        protected override Expression<Func<StreetNameSyndicationItem, StreetNameSyndicationQueryResult>> Transformation => _embed
            ? (Expression<Func<StreetNameSyndicationItem, StreetNameSyndicationQueryResult>>)(x =>
                new StreetNameSyndicationQueryResult(
                    x.StreetNameId,
                    x.Position,
                    x.OsloId,
                    x.NisCode,
                    x.ChangeType,
                    x.RecordCreatedAt,
                    x.LastChangedOn,
                    x.Status,
                    x.NameDutch,
                    x.NameFrench,
                    x.NameGerman,
                    x.NameEnglish,
                    x.HomonymAdditionDutch,
                    x.HomonymAdditionFrench,
                    x.HomonymAdditionGerman,
                    x.HomonymAdditionEnglish,
                    x.IsComplete,
                    x.Organisation,
                    x.Plan))
            : x =>
                new StreetNameSyndicationQueryResult(
                    x.StreetNameId,
                    x.Position,
                    x.OsloId,
                    x.NisCode,
                    x.ChangeType,
                    x.RecordCreatedAt,
                    x.LastChangedOn,
                    x.IsComplete,
                    x.Organisation,
                    x.Plan);

        protected override IQueryable<StreetNameSyndicationItem> Filter(FilteringHeader<StreetNameSyndicationFilter> filtering)
        {
            var streetNames = _context
                .StreetNameSyndication
                .AsNoTracking();

            if (!filtering.ShouldFilter)
                return streetNames;

            if (filtering.Filter.Position.HasValue)
                streetNames = streetNames.Where(m => m.Position >= filtering.Filter.Position);

            return streetNames;
        }
    }

    internal class StreetNameSyndicationSorting : ISorting
    {
        public IEnumerable<string> SortableFields { get; } = new[]
        {
            nameof(StreetNameSyndicationItem.Position)
        };

        public SortingHeader DefaultSortingHeader { get; } = new SortingHeader(nameof(StreetNameSyndicationItem.Position), SortOrder.Ascending);
    }

    public class StreetNameSyndicationFilter
    {
        public long? Position { get; set; }
    }
}
