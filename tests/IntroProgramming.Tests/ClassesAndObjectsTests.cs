using Person01 = IntroProgramming.ClassesAndObjects.Exercise01.Person;
using Person02 = IntroProgramming.ClassesAndObjects.Exercise02.Person;
using Person03 = IntroProgramming.ClassesAndObjects.Exercise03.Person;
using Person04 = IntroProgramming.ClassesAndObjects.Exercise04.Person;
using Exercise04 = IntroProgramming.ClassesAndObjects.Exercise04.Exercise;
using Person05 = IntroProgramming.ClassesAndObjects.Exercise05.Person;
using Rectangle06 = IntroProgramming.ClassesAndObjects.Exercise06.Rectangle;

namespace IntroProgramming.Tests;

public class ClassesAndObjectsTests
{
    [Fact]
    public void Exercise01_PersonHasName()
    {
        var person = new Person01();

        Assert.IsType<string>(person.Name);
        Assert.NotEqual("", person.Name);
    }

    [Fact]
    public void Exercise02_PersonInit()
    {
        var person = new Person02("Ada");

        Assert.Equal("Ada", person.Name);
        Assert.Equal("Alan", new Person02("Alan").Name);
    }

    [Fact]
    public void Exercise03_PersonGreet()
    {
        var person = new Person03("Ada");

        Assert.Equal("Hello, Ada!", person.Greet());
        Assert.Equal("Hello, Alan!", new Person03("Alan").Greet());
    }

    [Fact]
    public void Exercise04_TwoPeople()
    {
        var (first, second) = Exercise04.CreateTwoPeople();

        Assert.IsType<Person04>(first);
        Assert.IsType<Person04>(second);
        Assert.NotEqual(first.Name, second.Name);
        Assert.Equal($"Hello, {first.Name}!", first.Greet());
        Assert.Equal($"Hello, {second.Name}!", second.Greet());
    }

    [Fact]
    public void Exercise05_HaveBirthday()
    {
        var person = new Person05("Ada", 36);

        Assert.Equal("Ada", person.Name);
        Assert.Equal(36, person.Age);

        person.HaveBirthday();
        Assert.Equal(37, person.Age);

        person.HaveBirthday();
        Assert.Equal(38, person.Age);
    }

    [Fact]
    public void Exercise06_RectangleArea()
    {
        Assert.Equal(12, new Rectangle06(3, 4).Area());
        Assert.Equal(10, new Rectangle06(2, 5).Area());
        Assert.Equal(0, new Rectangle06(0, 9).Area());
    }
}
