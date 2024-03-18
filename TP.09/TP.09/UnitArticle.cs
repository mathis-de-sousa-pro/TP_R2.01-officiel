namespace TP._09
{
    /// <summary>
    /// Represents a unit article that inherits from the Article class.
    /// </summary>
    public class UnitArticle : Article
    {
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
        }
    }
}