using System.Runtime.Serialization;

namespace TP
{
    /// <summary>
    /// Classe Vulture, heriant de Bird
    /// </summary>
    [DataContract]
    public class Vulture : Bird
    {
        /// <summary>
        /// Renvoit la nourriture du vautour
        /// </summary>
        public override string Food { get => "des charognes"; }

        /// <summary>
        /// Renvoit l'espece du vautour
        /// </summary>
        public override string Species { get => "vautour"; }

        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        /// <param name="name">Nom du vautour</param>
        public Vulture(string name) : base(name) { }
    }
}
