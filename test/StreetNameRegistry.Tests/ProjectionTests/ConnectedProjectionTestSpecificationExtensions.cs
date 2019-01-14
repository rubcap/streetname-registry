namespace StreetNameRegistry.Tests.ProjectionTests
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Be.Vlaanderen.Basisregisters.ProjectionHandling.Connector;
    using Be.Vlaanderen.Basisregisters.ProjectionHandling.Connector.Testing;
    using FluentAssertions.Execution;
    using Microsoft.EntityFrameworkCore;
    using Projections.Legacy;

    public static class ConnectedProjectionTestSpecificationExtensions
    {
        public static async Task Assert(this ConnectedProjectionTestSpecification<LegacyContext> specification)
        {
            if (specification == null) throw new ArgumentNullException(nameof(specification));

            var options = new DbContextOptionsBuilder<LegacyContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using (var context = new LegacyContext(options))
            {
                context.Database.EnsureCreated();

                foreach (var message in specification.Messages)
                {
                    await new ConnectedProjector<LegacyContext>(specification.Resolver)
                        .ProjectAsync(context, message);

                    await context.SaveChangesAsync();
                }

                var result = await specification.Verification(context, CancellationToken.None);
                if (result.Failed)
                {
                    throw new AssertionFailedException(result.Message);
                }
            }
        }
    }
}
