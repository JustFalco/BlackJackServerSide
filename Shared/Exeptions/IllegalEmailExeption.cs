using System;

namespace Shared.Exeptions;

public class IllegalEmailExeption : Exception
{
    public IllegalEmailExeption()
    {
    }

    public IllegalEmailExeption(string message)
        : base(message)
    {
    }

    public IllegalEmailExeption(string message, Exception inner)
        : base(message, inner)
    {
    }
}