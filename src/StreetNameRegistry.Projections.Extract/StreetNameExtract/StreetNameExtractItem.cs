namespace StreetNameRegistry.Projections.Extract.StreetNameExtract
{
    using System;
    using Infrastructure;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class StreetNameExtractItem
    {
        public Guid? StreetNameId { get; set; }
        public int StreetNameOsloId { get; set; }
        public bool Complete { get; set; }
        public Language? ChosenLanguage { get; set; }
        public byte[] DbaseRecord { get; set; }
    }

    public class StreetNameExtractItemConfiguration : IEntityTypeConfiguration<StreetNameExtractItem>
    {
        public const string TableName = "StreetName";

        public void Configure(EntityTypeBuilder<StreetNameExtractItem> builder)
        {
            builder.ToTable(TableName, Schema.Extract)
                .HasKey(p => p.StreetNameId)
                .ForSqlServerIsClustered(false);

            builder.Property(p => p.StreetNameOsloId);
            builder.Property(p => p.Complete);
            builder.Property(p => p.ChosenLanguage);
            builder.Property(p => p.DbaseRecord);

            builder.HasIndex(p => p.StreetNameOsloId).ForSqlServerIsClustered();
        }
    }
}
