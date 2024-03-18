using System.Runtime.Serialization;

namespace TP
{
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

        public override string ToString()
        {
            return $"My name is {this.Name}, I'm a {this.Species} ({this.Breed}) and I eat {this.Food}";
        }
    }
}
