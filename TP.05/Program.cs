using System;
namespace TP._05;

static class Program
{
    
    static void Main()
    {
        #region TABLEAUX
        
        #region début

        Console.Write("tapez un entier : ");
        double[] tabX = new double[(int)Convert.ToDouble(Console.ReadLine())];
        int[] tabI = new int[] { 10, 15, 3, 4, 1 };
        Console.WriteLine($"la taille de tabI : {tabI.Length}");
        tabI[0] = 0;
        Console.WriteLine($"tabI[1] : {tabI[1]}");
        Console.WriteLine($"tabI[0] : {tabI[0]}");

        #endregion

        #region parcourDeTableau
        
        Console.Write("|| ");
        
        // À l’aide d’une boucle for, affichez à l’écran le contenu du tableau tabI.
        for(var i = 0; i < tabI.Length; i++)
        {
            Console.Write(tabI[i] + " || ");
        }
        
        Console.WriteLine();
        
        Console.Write("|| ");
        
        // À l’aide d’une boucle for, affichez à l’écran le contenu du tableau tabI, dans l’ordre inverse
        for(var i = tabI.Length - 1; i >= 0; i--)
        {
            Console.Write(tabI[i] + " || ");
        }
        
        Console.WriteLine();
        Console.Write("|| ");
        
        // À l’aide d’une boucle for, affichez à l’écran le contenu des indices pairs du tableau tabI.
        for(var i = 0; i < tabI.Length; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(tabI[i] + " || ");
            }
        }
        
        #endregion

        #region somme
        
        Console.WriteLine();
        
        // À l’aide d’une boucle foreach, calculez la somme des éléments du tableau tabI et faites-là afficher.
        int somme = 0;
        foreach (int elem in tabI)
        {
            somme += elem;
        }
        Console.WriteLine(somme);
        
        // méthode alternative
        Console.WriteLine(tabI.Sum());
        
        #endregion

        #region Tri

        Console.WriteLine();
        Console.Write("|| ");
        
        // Triez le tableau tabI puis affichez-le, pour vérifier.
        Array.Sort(tabI);
        foreach (var elem in tabI)
        {
            Console.Write(elem + " || ");
        }
        Console.WriteLine();
        Console.WriteLine();
        
        // Faites afficher la plus petite, la plus grande et la somme des valeurs du tableau tabI.
        Console.WriteLine($"valeur la plus petite : {tabI.Min()}");
        Console.WriteLine($"valeur la plus grande : {tabI.Max()}");
        Console.WriteLine($"somme de toutes les valeurs {tabI.Sum()}");
        
        #endregion
        
        // fin de la region TABLEAUX
        #endregion

        #region MATRICES
        
        // Remplir une matrice 2x3 de valeurs flottantes aléatoires entre 0 et 1
        int[,] matrice = new int[2,3];
        for (int ligne = 0; ligne < matrice.GetLength(0); ligne++)
        {
            for (int colonne = 0; colonne < matrice.GetLength(1); colonne++)
            {
                matrice[ligne, colonne] = Random.Shared.Next(2);
            }
        }
        // Affichez la matrice à l’écran
        Console.WriteLine(matrice[0,0] + " | "+matrice[0,1]+ " | "+matrice[0,2]);
        Console.WriteLine("---------");
        Console.WriteLine(matrice[1,0] + " | "+matrice[1,1]+ " | "+matrice[1,2]);

        #endregion

        #region LISTES

        Console.WriteLine();

        // Créez une liste mots contenant des chaînes de caractères.
        List<string> mots = new List<string>();
        
        //Faites saisir quelques mots à l’utilisateur et ajoutez-les dans le tableau dynamique, tant que ce dernier n’a pas saisi le mot « fin » (qui va donc être inclus).
        string word = "";
        while(word != "fin")
        {
            if (word != null){ mots.Add(word);}
            Console.WriteLine("tapez un mot ou 'fin' pour terminer : ");
            word = Console.ReadLine();
        }
        
        Console.WriteLine();
        
        // Faites afficher, à l’aide de l’opération Count, le nombre d’éléments saisis.
        Console.WriteLine($"nombre d'éléments dans le tableau : {mots.Count}");
        
        // Utilisez [] pour remplacer l’avant-dernier élément par « presque fini ».
        mots[mots.Count - 1] = "presque fini ";
        
        // Utilisez foreach pour afficher sur l’écran le contenu du tableau.
        foreach (var elem in mots)
        {
            Console.WriteLine(elem);
        }

        // Supprimez le mot « fin » puis faites afficher de nouveau le tableau.
        mots.Remove("fin");
        Console.WriteLine();
        
        foreach (var elem in mots)
        {
            Console.WriteLine(elem);
        }

        Console.WriteLine();
        
        // Faites trier dans l’ordre alphabétique inverse, et faites afficher les 4 premières valeurs.
        mots.Sort(); mots.Reverse();
        foreach (var elem in mots.Take(4))
        {
            Console.WriteLine(elem);
        }
        
        #endregion

    }
}

