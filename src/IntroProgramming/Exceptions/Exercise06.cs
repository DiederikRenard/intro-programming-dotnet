namespace IntroProgramming.Exceptions;

/// <summary>
/// Exercise 06: exception message.
/// Throw ArgumentException(message), catch it, and return exception.Message.
/// </summary>
public static class Exercise06
{
    public static string GetErrorMessage(string message)
    {
        // TODO: throw, catch, and return the message
        try
        {
            throw new ArgumentException(message);
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }
        
        throw new NotImplementedException();
    }
}
