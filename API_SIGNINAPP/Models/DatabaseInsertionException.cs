using System;

public class DatabaseInsertionException : Exception
{
	public DatabaseInsertionException()
	{
	}

    public DatabaseInsertionException(string message)
       : base(message)
    {
    }

    public DatabaseInsertionException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
