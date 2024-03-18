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
        UnitArticle ream1 = new UnitArticle("R200", "Rame de papier ClairRuisseau", 6.25f, "ClairRuisseau");

        // Create a bundle of 200 pens with a 10% reduction
        Bundle penBundle = new Bundle("BUN1", 200, pen, 10);

        // Print the details of the pen bundle and the ream
        Console.WriteLine(penBundle.ToString());
        Console.WriteLine(ream1.ToString());

        #endregion
        
        #region Programme de test complet
        
        // Create a Person instance for the client "Paul Rich"
        Person client = new Person { FirstName = "Paul", LastName = "Rich" };

        // Create a Bill instance for the client
        Bill bill = new Bill(client);

        // Create UnitArticle instances for the green pens and the ream of paper
        UnitArticle greenPen = new UnitArticle("GreenPen00", "boc", 1.05f, "green pen");
        UnitArticle ream2 = new UnitArticle("Ream500", "ClairRuisseau", 4.45f, "500 sheets of white paper");

        // Create Bundle instances for the bundle of blue pens and the bundle of elastics
        Bundle bluePenBundle = new Bundle("BluePen00", 20, new UnitArticle("BluePen00", "boc", 0.82f, "blue pen"), 6);
        Bundle elasticBundle = new Bundle("ELA01", 1000, new UnitArticle("ELA01", "Latex", 0.07f, "simple yellow elastic"), 10);

        // Add the articles and bundles to the bill
        bill.AddArticle(greenPen);
        bill.AddArticle(ream2);
        bill.AddArticle(bluePenBundle);
        bill.AddArticle(elasticBundle);

        // Display the bill in the console
        Console.WriteLine(bill.ToString());
        #endregion
    }
}