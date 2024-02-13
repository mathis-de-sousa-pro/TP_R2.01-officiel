namespace TD._04;

public class Program
{
    public static void Main()
    {
        // Create a new Catalog
        Catalog catalog = new Catalog();
        
        Category category1 = new Category();
        category1.Name = "Category 1";
        
        // Create new Products
        Product product1 = new Product(category1,"Product 1");
        Product product2 = new Product(category1,"Product 2");

        // Add the products to the catalog
        catalog.AddProduct(product1);
        catalog.AddProduct(product2);

        // Display the products in the catalog
        Console.WriteLine(catalog.FindProductByName("Product 1"));
        Console.WriteLine(catalog.FindProductByName("Product 2"));
        Console.WriteLine(catalog.ToString());
    }
}