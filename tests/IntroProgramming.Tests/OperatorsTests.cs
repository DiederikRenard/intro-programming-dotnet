using IntroProgramming.Operators;

namespace IntroProgramming.Tests;

public class OperatorsTests
{
    [Fact]
    public void Exercise01_Arithmetic()
    {
        var (sum, difference, product, quotient, floorDivision, remainder) = Exercise01.Arithmetic(10, 3);

        Assert.Equal(13, sum);
        Assert.Equal(7, difference);
        Assert.Equal(30, product);
        Assert.Equal(10d / 3d, quotient, precision: 10);
        Assert.Equal(3, floorDivision);
        Assert.Equal(1, remainder);
    }

    [Fact]
    public void Exercise02_Compare()
    {
        Assert.Equal((true, false, false, true), Exercise02.Compare(3, 5));
        Assert.Equal((false, true, false, true), Exercise02.Compare(5, 3));
        Assert.Equal((false, false, true, false), Exercise02.Compare(4, 4));
    }

    [Fact]
    public void Exercise03_Logical()
    {
        Assert.Equal((true, true, false), Exercise03.Logical(true, true));
        Assert.Equal((false, true, false), Exercise03.Logical(true, false));
        Assert.Equal((false, true, true), Exercise03.Logical(false, true));
        Assert.Equal((false, false, true), Exercise03.Logical(false, false));
    }

    [Fact]
    public void Exercise04_ApplyAssignments()
    {
        Assert.Equal(new[] { 15, 12, 24 }, Exercise04.ApplyAssignments(10));
        Assert.Equal(new[] { 5, 2, 4 }, Exercise04.ApplyAssignments(0));
    }

    [Fact]
    public void Exercise05_CheckMembership()
    {
        Assert.Equal((true, false), Exercise05.CheckMembership("a", "cat"));
        Assert.Equal((false, true), Exercise05.CheckMembership(9, new List<int> { 1, 2, 3 }));
        Assert.Equal((true, false), Exercise05.CheckMembership(2, new List<int> { 1, 2, 3 }));
    }

    [Fact]
    public void Exercise06_PrecedenceDemo()
    {
        Assert.Equal((14, 20), Exercise06.PrecedenceDemo());
    }
}
