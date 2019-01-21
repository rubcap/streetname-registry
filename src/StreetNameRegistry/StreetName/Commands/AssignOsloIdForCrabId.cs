namespace StreetNameRegistry.StreetName.Commands
{
    using System;
    using System.Collections.Generic;
    using Be.Vlaanderen.Basisregisters.Crab;
    using Be.Vlaanderen.Basisregisters.Generators.Guid;
    using Be.Vlaanderen.Basisregisters.Utilities;

    public class AssignOsloIdForCrabId
    {
        private static readonly Guid Namespace = new Guid("06a988c7-40c2-4e6b-85a5-66a455faf74a");

        public CrabStreetNameId StreetNameId { get; }
        public OsloId OsloId { get; }
        public OsloAssignmentDate AssignmentDate { get; }

        public AssignOsloIdForCrabId(
            CrabStreetNameId streetNameId,
            OsloId osloId,
            OsloAssignmentDate assignmentDate)
        {
            StreetNameId = streetNameId;
            OsloId = osloId;
            AssignmentDate = assignmentDate;
        }

        public Guid CreateCommandId()
            => Deterministic.Create(Namespace, $"AssignOsloId-{ToString()}");

        public override string ToString()
            => ToStringBuilder.ToString(IdentityFields());

        private IEnumerable<object> IdentityFields()
        {
            yield return StreetNameId;
            yield return OsloId;
            yield return AssignmentDate;
        }
    }
}
