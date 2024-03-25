using System.Runtime.Serialization;

namespace TP;

    /// <summary>
    /// Classe Sheperd, heristant de Dog
    /// </summary>
    [DataContract]
    public class Sheperd : Dog
    {

        /// <summary>
        /// Renvoit la Race du Sheperd
        /// </summary>
        public override string Breed { get => "sheperd"; }

        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        /// <param name="name">Nom du sheperd</param>
        public Sheperd(string name) : base(name) { }
        
        /// <summary>
        /// Overrides the ToString method for the Sheperd class.
        /// </summary>
        /// <returns>
        /// A string representation of the Sheperd object, including its name, species, breed, and food.
        /// </returns>
        public override string ToString() => $"My name is {this.Name}, I'm a {this.Species} ({this.Breed}) and I eat {this.Food}";        
    }

