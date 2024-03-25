using System.Runtime.Serialization;

namespace TP;

/// <summary>
/// Classe Human, heriant de Animal
/// </summary>
[DataContract]
public class Human : Animal
{
    /// <summary>
    /// Renvoit l'espece de l'humain
    /// </summary>
    public override string Species
    {
        get => "humain";
    }

    /// <summary>
    /// Renvoit la nourriture de l'humain
    /// </summary>
    public override string Food
    {
        get => "du steak-frites";
    }

    /// <summary>
    /// Constructeur par defaut
    /// </summary>
    /// <param name="name">Nom de l'humain</param>
    public Human(string name) : base(name)
    {
    }

    /// <summary>
    /// Fait crier l'humain
    /// </summary>
    public override void Shout()
    {
    }
}