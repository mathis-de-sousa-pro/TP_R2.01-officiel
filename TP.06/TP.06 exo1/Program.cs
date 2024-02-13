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
    
    
    /*
    public static void RunTests()
    {
        var personTests = new PersonTests();
        personTests.PersonConstructor_InitializesCorrectly_WithValidArguments();
        personTests.PersonConstructor_ThrowsException_WhenFirstNameIsEmpty();
        personTests.PersonConstructor_ThrowsException_WhenLastNameIsEmpty();

        var accountTests = new AccountTests();
        accountTests.AccountConstructor_InitializesCorrectly_WithValidArguments();
        accountTests.Deposit_IncreasesBalance_ByCorrectAmount();
        accountTests.Withdraw_DecreasesBalance_ByCorrectAmount();
        accountTests.Withdraw_ThrowsException_WhenAmountExceedsBalance();
    }
    */
}