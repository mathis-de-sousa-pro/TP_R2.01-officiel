
using TP._03_exo_2;

public static class Program
 {
     public static void Main(string[] args)
      {
        #region 2 LA CLASSE TIME

        // Test de l'heure
        Time t1 = new Time(0);
        Time t2 = new Time(15, 24, 40);

        t1.Add(4000); // 4000s = 1heure 6 minutes 40 secondes
        t2.Add(30);
        Console.WriteLine(t1.ToString()); // 01:06:40
        Console.WriteLine(t2.ToString()); // 15:25:10
        Console.WriteLine(t1.Hours); // 1
        Console.WriteLine(t2.Minutes); // 25

        #endregion
    }
}
