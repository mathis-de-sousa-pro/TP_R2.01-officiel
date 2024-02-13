namespace TD._04;

public class Product
{
    private string _name;
    private Category _c;
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public Category C
    {
        get => _c;
        set => _c = value;
    }

    public Product(Category c, string name)
    {
        _c = c;
        _name = name;
    }    
}