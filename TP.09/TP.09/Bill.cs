using System.Text;

namespace TP._09;

/// <summary>
/// Represents a bill with a list of articles and a client.
/// </summary>
public class Bill
{
    #region attributs
    
    /// <summary>
    /// List of articles in the bill.
    /// </summary>
    private List<Article> _articles;

    /// <summary>
    /// The client associated with the bill.
    /// </summary>
    private Person _client;

    #endregion

    #region accesseurs

    /// <summary>
    /// Calculates the total price of all articles in the bill.
    /// </summary>
    /// <returns>The total price of all articles.</returns>
    public float TotalPrice()
    {
        float total = 0f;
        foreach (var art in _articles) { total += art.UnitPrice; }
        return total;
    }
    #endregion
    
    #region constructeurs

    public Bill(Person client)
    {
        _client = client;
        _articles = new List<Article>();
    }

    #endregion


    #region methodes

    /// <summary>
    /// Adds an article to the bill.
    /// </summary>
    /// <param name="article">The article to add.</param>
    public void AddArticle(Article article) => _articles.Add(article);
    
    /// <summary>
    /// Returns a string that represents the current bill.
    /// </summary>
    /// <returns>A string that represents the current bill.</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Client : {_client.FirstName} {_client.LastName}");
        sb.AppendLine("---------------------------------");
        foreach (var article in _articles)
        {
            sb.AppendLine(article.ToString());
        }
        sb.AppendLine("---------------------------------");
        sb.AppendLine($"Total price : {TotalPrice()}");
        return sb.ToString();
    }

    #endregion
   
}