using TP._09;

public class Program
{
    static void Main(string[] args)
    {
        
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
        UnitArticle greenPen = new UnitArticle("GreenPen00", "green pen", 1.05f, "boc");
        UnitArticle ream = new UnitArticle("Ream500", "500 sheets of white paper", 4.45f, "ClairRuisseau");

        // Create Bundle instances for the bundle of blue pens and the bundle of elastics
        UnitArticle bluePen = new UnitArticle("BluePen00", "blue pen", 1.05f, "boc");
        UnitArticle elastic = new UnitArticle("ELA01", "simple yellow elastic", 0.07f, "Latex");
        
        //
        Bundle bluePenBundle = new Bundle("BluePen00", 20, bluePen, 6);
        Bundle elasticBundle = new Bundle("ELA01", 1000, elastic, 10);

        // Add the articles and bundles to the bill
        bill.AddArticle(greenPen);
        bill.AddArticle(greenPen);
        bill.AddArticle(ream);
        bill.AddArticle(bluePenBundle);
        bill.AddArticle(elasticBundle);

        // Display the bill in the console
        Console.WriteLine(bill.ToString());
        #endregion
    }
}