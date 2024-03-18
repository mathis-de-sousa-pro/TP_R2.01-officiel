using TP._09;

public class Program
{
    static void Main(string[] args)
    {
        
        #region Testing Article class
        
        // Create an instance of Article
        Article article = new Article("A001", "Laptop", 1200.5f, "Dell");

        // Print the details of the article
        Console.WriteLine(article.ToString());
        
        #endregion

        #region Testing UnitArticle class

        // Create an instance of UnitArticle
        UnitArticle unitArticle = new UnitArticle("A002", "Pen", 1.5f, "Bic");

        // Print the details of the unit article
        Console.WriteLine(unitArticle.ToString());

        #endregion
        
        #region exercice 6

        // Create an instance of UnitArticle for Pen
        UnitArticle pen = new UnitArticle("P005", "Stylo Boc", 1.35f, "Boc");

        // Create an instance of UnitArticle for Ream
        UnitArticle ream = new UnitArticle("R200", "Rame de papier ClairRuisseau", 6.25f, "ClairRuisseau");

        // Create a bundle of 200 pens with a 10% reduction
        Bundle penBundle = new Bundle("BUN1", 200, pen, 10);

        // Print the details of the pen bundle and the ream
        Console.WriteLine(penBundle.ToString());
        Console.WriteLine(ream.ToString());

        #endregion
        
    }
}