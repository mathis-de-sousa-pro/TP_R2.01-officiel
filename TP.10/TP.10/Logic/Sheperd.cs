using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TP10.Logic
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
            return $"{this.Name} est un {this.Species} ({this.Breed}), et mange {this.Food}";
        }
    }
}
