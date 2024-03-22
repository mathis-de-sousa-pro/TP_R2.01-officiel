using System.Runtime.Serialization;

namespace TP;

/// <summary>
/// Classe Cocker, heriant de Dog
/// </summary>
[DataContract]
public class Cocker : Dog
{
    /// <summary>
    /// Race du Cocker
    /// </summary>
    public override string Breed { get => "cocker"; }

    /// <summary>
    /// Constructeur par defaut
    /// </summary>
    /// <param name="name">Nom du Cocker</param>
    public Cocker(string name) : base(name) { }
}