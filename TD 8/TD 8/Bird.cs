namespace TD_8;

public abstract class Bird : Animal
{
    protected Bird(string name) : base(name)
    {
    }
    
    public override void Shout()
    {
        Console.WriteLine("Tweet tweet");
    }
}