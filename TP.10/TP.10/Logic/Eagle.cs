using System.Runtime.Serialization;

namespace TP;

/// <summary>
/// Classe Eagle, heriant de Bird
/// </summary>
[DataContract]
public class Eagle : Bird
{
    /// <summary>
    /// Renvoit la nourriture de l'aigle
    /// </summary>
    public override string Food { get => "des rongeurs"; }

    /// <summary>
    /// Renvoit l'espece de l'aigle
    /// </summary>
    public override string Species { get => "aigle"; }

    /// <summary>
    /// Constructeur par defaut
    /// </summary>
    /// <param name="name">Nom de l'aigle</param>
    public Eagle(string name) : base(name) { }
}