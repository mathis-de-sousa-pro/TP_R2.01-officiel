namespace TP._03_exo_3;

public static class Program_03
{
    public static void Main(string[] args)
    {
        #region 3 LA CLASSE FRACTION
        
        Fraction f1 = new Fraction(5, 3);
        Fraction f2 = new Fraction(2, 7);

        Fraction f3 = Fraction.Add(f1, f2);
        Console.WriteLine("{0} = {1}",f3.ToString(), f3.Value);
        
        #endregion
    }
}