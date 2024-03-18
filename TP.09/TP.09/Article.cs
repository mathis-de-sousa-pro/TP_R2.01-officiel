namespace TP._09;

/// <summary>
/// Represents an article with properties such as description, unit price, and brand.
/// </summary>
public abstract class Article
{
    #region attributs

    // référence de l'article
    private string _reference;

    // Description de l'article
    private string _description;

    // Prix de l'article
    private float _unitPrice;

    // Marque de l'article
    private string _brand;

    #endregion

    #region accesseurs

    /// <summary>
    /// Gets the description of the article.
    /// </summary>
    public abstract string Description { get; }

    /// <summary>
    /// Gets the unit price of the article.
    /// </summary>
    public abstract float UnitPrice { get; }

    /// <summary>
    /// Gets the brand of the article.
    /// </summary>
    public abstract string Brand { get; }

    #endregion

    #region constructeurs

    /// <summary>
    /// Initializes a new instance of the <see cref="Article"/> class.
    /// </summary>
    /// <param name="reference">The reference of the article.</param>
    /// <param name="description">The description of the article.</param>
    /// <param name="unitPrice">The unit price of the article.</param>
    /// <param name="brand">The brand of the article.</param>
    public Article(string reference, string description, float unitPrice, string brand)
    {
        _reference = reference;
        _description = description;
        _unitPrice = unitPrice;
        _brand = brand;
    }

    #endregion

    #region méthodes

    /// <summary>
    /// Returns a string that represents the current article.
    /// </summary>
    /// <returns>A string that represents the current article.</returns>
    public override string ToString() => $"Référence : {_reference}, Description : {_description}, Prix unitaire : {_unitPrice}, Marque : {_brand}";

    #endregion
}