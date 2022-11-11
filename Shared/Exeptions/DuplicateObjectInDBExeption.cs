using System;

namespace Shared.Exeptions;

public class DuplicateObjectInDBExeption : Exception
{
    public DuplicateObjectInDBExeption()
    {
    }

    public DuplicateObjectInDBExeption(string message)
        : base(message)
    {
    }

    public DuplicateObjectInDBExeption(string message, Exception inner)
        : base(message, inner)
    {
    }
}