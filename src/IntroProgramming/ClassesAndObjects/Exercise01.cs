namespace IntroProgramming.ClassesAndObjects.Exercise01;

/// <summary>
/// Exercise 01: a simple class.
/// Set Name in the constructor to a non-empty string. The constructor takes no arguments.
/// </summary>
public class Person
{
    public string Name { get; set; } = "";

    public Person()
    {
        // TODO: set Name to a non-empty string
        Name = "Diederik Renardel";

        // throw new NotImplementedException();
    }
}
