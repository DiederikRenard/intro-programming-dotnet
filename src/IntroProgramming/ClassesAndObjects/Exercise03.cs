namespace IntroProgramming.ClassesAndObjects.Exercise03;

/// <summary>
/// Exercise 03: methods.
/// Store name. Greet returns "Hello, {Name}!".
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
