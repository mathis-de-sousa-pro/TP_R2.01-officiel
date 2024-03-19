namespace TP._09;

/// <summary>
/// Represents a person with a first name and a last name.
/// </summary>
public class Person
{
    private string? _lastName;

    /// <summary>
    /// Gets or sets the first name of the person.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or sets the last name of the person.
    /// </summary>
    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }
}