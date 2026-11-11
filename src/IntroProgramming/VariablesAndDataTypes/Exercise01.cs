namespace IntroProgramming.VariablesAndDataTypes;

/// <summary>
/// Exercise 01: basic int and double.
/// Return an int age and a double height. Both must be greater than 0.
/// </summary>
public static class Exercise01
{
    public static (int Age, double Height) GetAgeAndHeight()
    {
        // TODO: return (age, height). Age must be an int, height must be a double.
        int age = 25; // Example age
        double height = 1.75; // Example height in meters
        return (age, height);
    }
}
