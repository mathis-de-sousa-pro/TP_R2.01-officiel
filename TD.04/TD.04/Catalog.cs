namespace TD._04;

public class Catalog
{
    private List<Product> _products;
    public Catalog() => _products = new List<Product>();
    public void AddProduct(Product p) => _products.Add(p);
    public void RemoveProduct(Product p) => _products.Remove(p);
    public int Size => _products.Count;
    public Product FindProductByName(string name) => _products.Find(p => p.Name == name);
    
    public string ToString() // affiche la liste des catégories
    {
        string s = "";
        foreach (Product p in _products)
        {
            s += p.Name + " -> " + p.C.Name + "\n";
        }
        
        //affiche toute les catégories des produits (gere le cas ou on à deja affiché la catégorie)
        Dictionary<string, bool> categories = new Dictionary<string, bool>();
        foreach (Product p in _products)
        {
            if (!categories.ContainsKey(p.C.Name))
            {
                categories.Add(p.C.Name, true);
                s += p.C.Name + "\n";
            }
        }
        
        return s;
    }
}