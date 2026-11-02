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
        throw new NotImplementedException();
    }

    public string Greet()
    {
        // TODO: return the greeting
        throw new NotImplementedException();
    }
}

public static class Exercise
{
    public static (Person First, Person Second) CreateTwoPeople()
    {
        // TODO: return two Person instances with different names
        throw new NotImplementedException();
    }
}
