namespace TD_8;

/// <summary>
/// Represents an abstract Animal class.
/// </summary>
public abstract class Animal
{
    #region attributes

    /// <summary>
    /// Represents the name of the animal.
    /// </summary>
    private string _name;

    /// <summary>
    /// Represents the species of the animal.
    /// </summary>
    private string _species;

    /// <summary>
    /// Represents the food of the animal.
    /// </summary>
    private string _food;

    #endregion

    #region properties

    /// <summary>
    /// Gets the name of the animal.
    /// </summary>
    public string Name => _name;

    /// <summary>
    /// Abstract method to get the species of the animal.
    /// </summary>
    public abstract string Species();

    /// <summary>
    /// Abstract method to get the food of the animal.
    /// </summary>
    public abstract string Food();

    #endregion

    #region constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="Animal"/> class.
    /// </summary>
    /// <param name="name">The name of the animal.</param>
    public Animal(string name)
    {
        _name = name;
    }

    #endregion

    #region methods

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        return $"My name is {Name}, I'm a {Species()} and I eat {Food()}";
    }

    /// <summary>
    /// Abstract method for the animal to shout.
    /// </summary>
    public abstract void Shout();

    #endregion
}