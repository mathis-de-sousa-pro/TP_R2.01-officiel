namespace TP._09;

/// <summary>
/// Represents a bundle of articles.
/// </summary>
public class Bundle : Article
    {
        #region attributs
        
        // The number of articles in the bundle.
        private int _number;

        // The reduction rate applied to the bundle.
        private int _reductionRate;
        
        // The article to be bundled.
        private Article _article;
        
        #endregion

        #region accesseurs

        /// <summary>
        /// Gets the description of the unit article. Inherited from the Article class.
        /// </summary>
        public override string Description
        {
             get => _article.Description +" x "+ _number.ToString();
        }       
        
        /// <summary>
        /// Gets the unit price of the unit article. Inherited from the Article class.
        /// </summary>
        public override float UnitPrice => _article.UnitPrice * _number * (1 - _reductionRate / 100);
        
        /// <summary>
        /// Gets the brand of the unit article. Inherited from the Article class.
        /// </summary>
        public override string Brand => _article.Brand;
        
        #endregion
        
        #region construceurs
        
        

        /// <summary>
        /// Initializes a new instance of the <see cref="Bundle"/> class.
        /// </summary>
        /// <param name="reference">The reference of the bundle.</param>
        /// <param name="nb">The number of articles in the bundle.</param>
        /// <param name="article">The article to be bundled.</param>
        /// <param name="rate">The reduction rate to be applied to the bundle.</param>
        public Bundle(string reference,int nb, Article article, int rate)
            : base(reference)
        {
            _number = nb;
            _reductionRate = rate;
            _article = article;
        }
        
        #endregion
        
    }