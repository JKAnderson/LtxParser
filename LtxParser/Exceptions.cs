using System;

namespace LtxParser
{
    public class DuplicateSectionException : Exception
    {
        public DuplicateSectionException() { }
        public DuplicateSectionException(string message) : base(message) { }
        public DuplicateSectionException(string message, Exception inner) : base(message, inner) { }
    }

    public class InheritedSectionNotFoundException : Exception
    {
        public InheritedSectionNotFoundException() { }
        public InheritedSectionNotFoundException(string message) : base(message) { }
        public InheritedSectionNotFoundException(string message, Exception inner) : base(message, inner) { }
    }

    public class OrphanedFieldException : Exception
    {
        public OrphanedFieldException() { }
        public OrphanedFieldException(string message) : base(message) { }
        public OrphanedFieldException(string message, Exception inner) : base(message, inner) { }
    }

    public class LtxFormatException : Exception
    {
        public LtxFormatException() { }
        public LtxFormatException(string message) : base(message) { }
        public LtxFormatException(string message, Exception inner) : base(message, inner) { }
    }
}
