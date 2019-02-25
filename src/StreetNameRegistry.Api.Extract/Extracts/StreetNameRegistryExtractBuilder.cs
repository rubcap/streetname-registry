namespace StreetNameRegistry.Api.Extract.Extracts
{
    using Projections.Extract;
    using System.Linq;
    using Be.Vlaanderen.Basisregisters.Api.Extract;
    using Be.Vlaanderen.Basisregisters.GrAr.Extracts;
    using Microsoft.EntityFrameworkCore;

    public class StreetNameRegistryExtractBuilder
    {
        public static ExtractFile CreateStreetNameFile(ExtractContext context)
        {
            var extractItems = context
                .StreetNameExtract
                .AsNoTracking()
                .Where(x => x.Complete);

            return ExtractBuilder.CreateDbfFile<StreetNameDbaseRecord>(
                ExtractController.ZipName,
                new StreetNameDbaseSchema(),
                extractItems.OrderBy(x => x.StreetNameOsloId).Select(org => org.DbaseRecord),
                extractItems.Count);
        }
    }
}
