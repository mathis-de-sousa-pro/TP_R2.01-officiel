using System.Runtime.Serialization;

namespace TP
{

    /// <summary>
    /// Classe abstraite Bird, heriant de Animal
    /// </summary>
    [DataContract]
    public abstract class Bird : Animal
    {
        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        /// <param name="name">Nom de l'oiseau</param>
        public Bird(string name) : base(name) { }

        /// <summary>
        /// Fait crier l'oiseau
        /// </summary>
        public override void Shout()
        {

        }
    }
}
