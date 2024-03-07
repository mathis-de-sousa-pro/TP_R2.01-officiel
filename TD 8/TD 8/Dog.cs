namespace TD_8;

/// <summary>
/// Represents a Dog class that inherits from the Animal class.
/// </summary>
public abstract class Dog : Animal
{
    #region Attributes

    /// <summary>
    /// Represents the breed of the dog.
    /// </summary>
    private string _breed;

    #endregion

    #region Methods

    /// <summary>
    /// Abstract method to get the breed of the dog.
    /// </summary>
    public abstract void Breed();

    /// <summary>
    /// Initializes a new instance of the <see cref="Dog"/> class.
    /// </summary>
    /// <param name="name">The name of the dog.</param>
    protected Dog(string name) : base(name)
    {
    }

    /// <summary>
    /// Overrides the Shout method from the Animal class.
    /// </summary>
    public override void Shout()
    {
        Console.WriteLine("Woof woof");
    }

    #endregion
}