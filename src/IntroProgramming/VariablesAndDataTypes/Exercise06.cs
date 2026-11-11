namespace IntroProgramming.VariablesAndDataTypes;

/// <summary>
/// Exercise 06: multiple types.
/// Return an int, a double, a string, and a bool, in that order. The number and decimal must be greater than 0 and the text must not be empty.
/// </summary>
public static class Exercise06
{
    public static (int Number, double Decimal, string Text, bool Flag) ExampleValues()
    {
        // TODO: return (number, decimalValue, text, flag)
        int number = 42; // Example int greater than 0
        double decimalValue = 3.14; // Example double greater than 0
        string text = "Hello, World!"; // Example string that is not empty
        bool flag = true; // Example bool
        return (number, decimalValue, text, flag);
        throw new NotImplementedException();
    }
}
