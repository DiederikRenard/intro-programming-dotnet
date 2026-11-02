using IntroProgramming.Conditionals;

namespace IntroProgramming.Tests;

public class ConditionalsTests
{
    [Fact]
    public void Exercise01_IsPositive()
    {
        Assert.True(Exercise01.IsPositive(3));
        Assert.False(Exercise01.IsPositive(0));
        Assert.False(Exercise01.IsPositive(-1));
    }

    [Fact]
    public void Exercise02_EvenOrOdd()
    {
        Assert.Equal("even", Exercise02.EvenOrOdd(4));
        Assert.Equal("odd", Exercise02.EvenOrOdd(7));
        Assert.Equal("even", Exercise02.EvenOrOdd(0));
    }

    [Fact]
    public void Exercise03_LetterGrade()
    {
        Assert.Equal("A", Exercise03.LetterGrade(100));
        Assert.Equal("A", Exercise03.LetterGrade(90));
        Assert.Equal("B", Exercise03.LetterGrade(89));
        Assert.Equal("B", Exercise03.LetterGrade(80));
        Assert.Equal("C", Exercise03.LetterGrade(79));
        Assert.Equal("C", Exercise03.LetterGrade(70));
        Assert.Equal("D", Exercise03.LetterGrade(69));
        Assert.Equal("D", Exercise03.LetterGrade(60));
        Assert.Equal("F", Exercise03.LetterGrade(59));
        Assert.Equal("F", Exercise03.LetterGrade(0));
    }

    [Fact]
    public void Exercise04_Classify()
    {
        Assert.Equal("positive even", Exercise04.Classify(4));
        Assert.Equal("positive odd", Exercise04.Classify(3));
        Assert.Equal("not positive", Exercise04.Classify(0));
        Assert.Equal("not positive", Exercise04.Classify(-2));
    }

    [Fact]
    public void Exercise05_YesOrNo()
    {
        Assert.Equal("yes", Exercise05.YesOrNo(true));
        Assert.Equal("no", Exercise05.YesOrNo(false));
    }

    [Fact]
    public void Exercise06_Matches()
    {
        Assert.True(Exercise06.Matches(1));
        Assert.True(Exercise06.Matches(9));
        Assert.True(Exercise06.Matches(100));
        Assert.False(Exercise06.Matches(0));
        Assert.False(Exercise06.Matches(10));
        Assert.False(Exercise06.Matches(50));
    }
}
