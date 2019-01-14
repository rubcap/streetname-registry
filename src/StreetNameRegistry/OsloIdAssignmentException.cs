namespace StreetNameRegistry
{
    using System;

    public class OsloIdAssignmentException : StreetNameRegistryException
    {
        public OsloIdAssignmentException() { }

        public OsloIdAssignmentException(string message) : base(message) { }

        public OsloIdAssignmentException(string message, Exception inner) : base(message, inner) { }
    }
}
