namespace IntroProgramming.ClassesAndObjects.Exercise04;

/// <summary>
/// Exercise 04: multiple instances.
/// Person.Greet returns "Hello, {Name}!".
/// CreateTwoPeople returns two Person instances with different names.
/// </summary>
public class Person
{
    public string Name { get; set; } = "";

    public Person(string name)
    {
        // TODO: set Name
        Name = name;
        // throw new NotImplementedException();
    }

    public string Greet()
    {
        // TODO: return the greeting
        return $"Hello, {Name}!";
        // throw new NotImplementedException();
    }
}

public static class Exercise
{
    public static (Person First, Person Second) CreateTwoPeople()
    {
        // TODO: return two Person instances with different names
        var First = new Person("Faolan Renardel");
        var Second = new Person("Freya Renardel");
        return (First, Second);
    }
}
