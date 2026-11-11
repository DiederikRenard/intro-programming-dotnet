namespace IntroProgramming.VariablesAndDataTypes;

/// <summary>
/// Exercise 04: type conversion.
/// Convert value to int. "42" becomes 42. 3.14 becomes 3 (truncate toward zero, do not round).
/// </summary>
public static class Exercise04
{
    public static int ToInt(object value)
    {
        // TODO: convert a string or double to int
        if (value is string strValue)
        {
            return int.Parse(strValue);
        }
        else if (value is double doubleValue)
        {
            return (int)doubleValue; // Truncate toward zero
        }
        else
        {
            throw new ArgumentException("Value must be a string or double.");
        }
        throw new NotImplementedException();
    }
}
