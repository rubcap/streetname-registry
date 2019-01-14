namespace StreetNameRegistry.Projections.Syndication.Municipality
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Infrastructure;
    using System;

    public class MunicipalityLatestItem
    {
        public Guid MunicipalityId { get; set; }
        public string NisCode { get; set; }
        public string NameDutch { get; set; }
        public string NameFrench { get; set; }
        public string NameGerman { get; set; }
        public string NameEnglish { get; set; }
        public DateTimeOffset? Version { get; set; }
        public long Position { get; set; }
    }

    public class MunicipalityLatestItemConfiguration : IEntityTypeConfiguration<MunicipalityLatestItem>
    {
        private const string TableName = "MunicipalityLatestSyndication";

        public void Configure(EntityTypeBuilder<MunicipalityLatestItem> builder)
        {
            builder.ToTable(TableName, Schema.Syndication)
                .HasKey(x => x.MunicipalityId)
                .ForSqlServerIsClustered(false);

            builder.Property(x => x.NisCode);
            builder.Property(x => x.NameDutch);
            builder.Property(x => x.NameFrench);
            builder.Property(x => x.NameGerman);
            builder.Property(x => x.NameEnglish);
            builder.Property(x => x.Version);
            builder.Property(x => x.Position);

            builder.HasIndex(x => x.Position);
            builder.HasIndex(x => x.NisCode).ForSqlServerIsClustered();
            builder.HasIndex(x => x.NameDutch);
            builder.HasIndex(x => x.NameFrench);
            builder.HasIndex(x => x.NameEnglish);
            builder.HasIndex(x => x.NameGerman);
        }
    }
}
