using System.Text;

namespace TP._09;

public class Bill
{
    private List<Article> _articles;
    private Person _client;
    public float TotalPrice()
    {
        float total = 0f;
        foreach (var art in _articles) { total += art.UnitPrice; }
        return total;
    }
    
    public void AddArticle(Article article)
    {
        _articles.Add(article);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Client : {_client.FirstName} {_client.LastName}");
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
}