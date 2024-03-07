namespace TD_8;

/// <summary>
/// Represents a Human class that inherits from the Animal class.
/// </summary>
public class Human : Animal
{
    #region Constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="Human"/> class.
    /// </summary>
    /// <param name="name">The name of the human.</param>
    public Human(string name) : base(name)
    {
    }

    #endregion

    #region Methods

    /// <summary>
    /// Overrides the Species method from the Animal class.
    /// </summary>
    /// <returns>A string representing the species of the human.</returns>
    public override string Species()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Overrides the Food method from the Animal class.
    /// </summary>
    /// <returns>A string representing the food of the human.</returns>
    public override string Food()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Overrides the Shout method from the Animal class.
    /// </summary>
    public override void Shout()
    {
        Console.WriteLine("Hello");
    }

    #endregion
}