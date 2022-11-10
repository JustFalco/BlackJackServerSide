namespace Shared.Exeptions;

public class NoEntitiesInDatabaseExeption : Exception
{
    public NoEntitiesInDatabaseExeption()
    {
    }

    public NoEntitiesInDatabaseExeption(string message)
        : base(message)
    {
    }

    public NoEntitiesInDatabaseExeption(string message, Exception inner)
        : base(message, inner)
    {
    }
}