using System.Data.SqlTypes;

namespace TP._01;

public enum Gender
{
    Male, Femelle
}

public class Humain : Personnage
{
    private Gender _sexe;
    private bool _havepower;
    private bool _isJedi;
    
    public Humain(string nom, bool vie, Gender sexe, bool power, bool jedi) : base(nom, vie)
    {
        _sexe = sexe;
        _havepower = power;
        _isJedi = jedi;
    }
    
    public Gender Sexe
    {
        get => _sexe;
        set => _sexe = value;
    }

    public bool IsJedi
    {
        get => _isJedi;
        set => _isJedi = value;
    }

    public bool HavePower
    {
        get => _havepower;
        set => _havepower = value;
    }

    public void Manger()
    {
        
    }

    public void Combattre()
    {
        
    }

    public void Dormir()
    {
        
    }

    public void Parler()
    {
        
    }
}