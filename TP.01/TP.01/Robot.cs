namespace TP._01;

public class Robot : Personnage
{    
    public string _fonction { get; set; }

    public Robot(string fonction, string nom, bool vie) : base(nom, vie)
    {
        _fonction = fonction;
    }
    
    public void Combattre()
    {
        
    }
    
    public void Parler()
    {
        
    }

    
}