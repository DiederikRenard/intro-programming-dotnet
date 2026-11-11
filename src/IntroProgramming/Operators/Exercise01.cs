namespace IntroProgramming.Operators;

/// <summary>
/// Exercise 01: arithmetic.
/// Return (a + b, a - b, a * b, (double)a / b, integer division, a % b).
/// Integer division here matches floor division for these non-negative inputs.
/// </summary>
public static class Exercise01
{
    public static (int Sum, int Difference, int Product, double Quotient, int FloorDivision, int Remainder) Arithmetic(int a, int b)
    {
        // TODO: return the six results
        int sum = a + b;
        int difference = a - b;
        int product = a * b;
        double quotient = (double)a / b;
        int floorDivision = a / b;
        int remainder = a % b;
        return (sum, difference, product, quotient, floorDivision, remainder);
        throw new NotImplementedException();
    }
}
