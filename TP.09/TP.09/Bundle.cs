namespace TP._09
{
    /// <summary>
    /// Represents a bundle of articles.
    /// </summary>
    public class Bundle : Article
    {
        // The number of articles in the bundle.
        private int _number;

        // The reduction rate applied to the bundle.
        private int _reductionRate;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bundle"/> class.
        /// </summary>
        /// <param name="reference">The reference of the bundle.</param>
        /// <param name="nb">The number of articles in the bundle.</param>
        /// <param name="article">The article to be bundled.</param>
        /// <param name="rate">The reduction rate to be applied to the bundle.</param>
        public Bundle(string reference,int nb, Article article, int rate)
            : base(reference, article.Description+$" x {nb}", article.UnitPrice, article.Brand)
        {
            _number = nb;
            _reductionRate = rate;
        }
    }
}