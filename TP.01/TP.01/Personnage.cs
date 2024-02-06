namespace TP._01;

public class Personnage
{
    private string _nom;
    private bool _isAlive;

    public Personnage(string nom, bool alive)
    {
        _nom = nom;
        _isAlive = alive;
    }

    public string Nom
    {
        get => _nom;
        set => _nom = value;
    }

    public bool IsAlive
    {
        get => _isAlive;
        set => _isAlive = value;
    }
}