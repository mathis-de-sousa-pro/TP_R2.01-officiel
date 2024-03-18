using System.Runtime.Serialization;

namespace TP
{
    /// <summary>
    /// Classe abstraite Dog, heriant de Animal
    /// </summary>
    [DataContract]
    public abstract class Dog : Animal
    {
        /// <summary>
        /// Espece du chien
        /// </summary>
        public override string Species { get => $"chien"; }

        /// <summary>
        /// Race du chien
        /// </summary>
        public abstract string Breed { get; }

        /// <summary>
        /// La nourriture du chien
        /// </summary>
        public override string Food { get => "de la viande"; }

        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        /// <param name="name">Nom du chien</param>
        public Dog(string name) : base(name) { }

        /// <summary>
        /// Fait aboyer le chien
        /// </summary>
        public override void Shout()
        {
            /**/
        }

        /// <summary>
        /// Convertie l'instance de la classe Dog en string
        /// </summary>
        /// <returns>Son nom puis son espece, puis sa nourriture en une phrase</returns>
        public override string ToString()
        {
            return $"{this.Name} est un {this.Species} ({this.Breed}), et mange {this.Food}";
        }
    }
}
