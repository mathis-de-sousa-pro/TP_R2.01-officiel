namespace TP._09;

/// <summary>
/// Represents a unit article that inherits from the Article class.
/// </summary>
public class UnitArticle : Article
{
    #region attributs

    private string _description;
    private float _unitPrice;
    private string _brand;

    #endregion
    #region constructeurs

    /// <summary>
    /// Initializes a new instance of the <see cref="UnitArticle"/> class.
    /// </summary>
    /// <param name="reference">The reference of the unit article.</param>
    /// <param name="description">The description of the unit article.</param>
    /// <param name="unitPrice">The unit price of the unit article.</param>
    /// <param name="brand">The brand of the unit article.</param>
    public UnitArticle(string reference, string description, float unitPrice, string brand)
        : base(reference, description, unitPrice, brand)
    {
        _description = description;
        _unitPrice = unitPrice;
        _brand = brand;
    }

    #endregion
    
    #region accesseurs

    /// <summary>
    /// Gets the description of the unit article. Inherited from the Article class.
    /// </summary>
    public override string Description => _description;

    /// <summary>
    /// Gets the unit price of the unit article. Inherited from the Article class.
    /// </summary>
    public override float UnitPrice => _unitPrice;

    /// <summary>
    /// Gets the brand of the unit article. Inherited from the Article class.
    /// </summary>
    public override string Brand => _brand;

    #endregion
}
