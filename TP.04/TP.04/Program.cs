namespace TP._04;

public class Program
{
    static void Main()
    {
        Test t1 = new Test();
        Test t2 = new Test();
        t1.Val = 10;
        Test t = new Test(t1);
        
        Test t3 = new Test(t1);
        Console.WriteLine($"la valeur contenue dans t3 : {t3.Val}");
        
        t1.Val = -1;
        Console.WriteLine("nombre d'instances : " + Test.Combien() + " | t1 : " +t1.Val + " |  t2 : " +t2.Val + " | t3 : " +t3.Val + " | t : " + t.Val);

        t1.Val = 0;
        t3.Val = 0;
        t.Val = 0;
        Console.WriteLine("nombre d'instances : " + Test.Combien() + " | t1 : " +t1.Val + " |  t2 : " +t2.Val + " | t3 : " +t3.Val + " | t : " + t.Val);
        
        Console.WriteLine();
        Console.WriteLine("Comparaison par référence vec '==' : ");
        Console.WriteLine(t1 == t2);
        Console.WriteLine(t1 == t3);
        Console.WriteLine(t1 == t);
        
        Console.WriteLine();
        Console.WriteLine("Comparaison par valeur avec la méthode Equals : ");
        Console.WriteLine(t1.Equals(t2));
        Console.WriteLine(t1.Equals(t3));
        Console.WriteLine(t1.Equals(t));

        for (var compteur = 1; compteur <= 500000; compteur++)
        {
            Test n = new Test();
            n.Val = t1.Val;
        }
        Console.WriteLine($"Nombre D'instances {Test.Combien()}");
        Thread.Sleep(5000);
        Console.WriteLine($"Nombre D'instances {Test.Combien()}");

    }
}
