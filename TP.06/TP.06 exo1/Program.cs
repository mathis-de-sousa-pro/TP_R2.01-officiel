using TP._06_exercice_1;

namespace TP_06;
public class Program
{
    public static void Main()
    {
        Person p = new Person("Doe", "John");
        Account c = new Account(p, "1243-1298XX");
        c.Deposit(1500);
        c.Withdraw(75);
        Console.WriteLine(c);
        
    }
}