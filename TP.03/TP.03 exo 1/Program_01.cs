namespace TP._03_exo_1;

public static class Program_01
{
    public static void Main(string[] args)
    {
        #region 1 LA CLASSE PRODUCT

        Product.Vat = 0.2f;
        Product telephone = new Product("SP01", "Smarphone FaitIUT 0121", 250);
        Console.WriteLine($"nom : {telephone.Name} || prix hors taxe : {telephone.PrixHt}");
        telephone.PrixHt = 200;
        telephone.Name = "Smarphone FaitIUT 0121";
        Console.WriteLine($"nom : {telephone.Name} || prix avec la tva : {telephone.PrixTTC}");
        Console.WriteLine($"le code du produit telephone : {telephone.Code}");
        
        #endregion
    }
}