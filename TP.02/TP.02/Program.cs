namespace TP._02;

public class Programm
{
    static void Main()
    {
        #region test_accesseur
        
        Printer i1 = new(0, 0, 0);
         Console.WriteLine(i1.Isempty());
         for (var i = 0; i <= 10; i++)
         {
             Console.Write(i1.HaveEnoughSheets(i)+("""" || """"));
         }

         Console.WriteLine();
         Console.WriteLine(i1.Cost);
         
        #endregion;

        #region test_LoadSheets
        
        Printer imprimante = new(0, 0, 0);
        
        imprimante.LoadSheets(100);
        Console.Write(imprimante.HaveEnoughSheets(100) + (" || "));
        Console.WriteLine(imprimante.HaveEnoughSheets(101));
        
        imprimante.LoadSheets(10);
        Console.Write(imprimante.HaveEnoughSheets(101) + (" || "));
        Console.WriteLine(imprimante.HaveEnoughSheets(111));
        
        #endregion

        #region Modificateurs
        
        // Créez un objet Printer
        Printer printer = new Printer(0.25f,0, 0);

        // Chargez l'objet avec 100 feuilles
        printer.LoadSheets(100);

        // Imprimez 10 pages
        printer.Print(10);

        // Vérifiez que le coût actuel est de 2,5€
        Console.WriteLine($"Coût actuel après impression de 10 pages: {printer.TotalPrice}€");

        // Imprimez ensuite 15 pages
        printer.Print(15);

        // Vérifiez que le coût actuel est de 6 €
        Console.WriteLine($"Coût actuel après impression de 15 pages: {Math.Round(printer.TotalPrice)}€");

        // Imprimez ensuite 40 pages
        printer.Print(40);

        // Vérifiez que le coût actuel est de 13.5 €
        Console.WriteLine($"Coût actuel après impression de 40 pages: {Math.Round(printer.TotalPrice)}€");

        // Relevez l'argent (TakeMoney)
        printer.TakeMoney();

        // Vérifiez que le coût actuel est de 0 €.
        Console.WriteLine($"Coût actuel après avoir pris l'argent: {printer.TotalPrice}€");

        // Imprimez ensuite 40 pages
        printer.Print(40);

        // Vérifiez que IsEmpty est bien égal à true
        Console.WriteLine($"La machine est vide : {printer.Isempty()}");

        // Vérifiez que le coût actuel est de 7€
        Console.WriteLine($"Coût actuel après impression de 40 pages après avoir pris l'argent: {Math.Round(printer.TotalPrice)}€");
        

        #endregion

        #region Programme_Principal
        // Créer un objet Printer pour la salle des professeurs
        Printer salleDesProfs = new Printer(0.25f, 1000, 0);

        //Créer une instance de la classe Printer pour la bibliothèque
        Printer bibliotheque = new Printer(0.25f, 1000, 0);

        
        
        // Un.e enseignant.e demande 200 photocopies dans la salle des professeurs.
        salleDesProfs.Print(200);

        // Un.e étudiant.e retire 12 photocopies à la bibliothèque.
        bibliotheque.Print(12);
        
        // Un.e enseignant.e demande 500 photocopies dans la salle des professeurs.
        salleDesProfs.Print(500);

        // Un.e étudiant.e retire 30 photocopies à la bibliothèque.
        bibliotheque.Print(30);
        
        // Un.e enseignant.e demande 400 photocopies dans la salle des professeurs.
        salleDesProfs.Print(400);

        // Un.e étudiant.e retire 3 photocopies à la bibliothèque.
        bibliotheque.Print(3);
        
        
        
        //affichage des resultats.
        Console.WriteLine(" BIBLIOTHEQUE   || prix actuel par feuille : " + bibliotheque.Cost  + " | cout total pour les dernières impressions : " + Math.Round(bibliotheque.TotalPrice));
        Console.WriteLine("SALLE DES PROFS || prix actuel par feuille : " + bibliotheque.Cost + " | cout total pour les dernières impressions : " + Math.Round(salleDesProfs.TotalPrice));

        #endregion
    }
}
