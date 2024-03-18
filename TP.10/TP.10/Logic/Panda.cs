using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TP10.Logic
{
    /// <summary>
    /// Classe Panda, heritant de Animal
    /// </summary>
    [DataContract]
    public class Panda : Animal
    {
        /// <summary>
        /// L'espece du panda
        /// </summary>
        public override string Species => "Panda";

        /// <summary>
        /// La nourriture du panda
        /// </summary>
        public override string Food => "du bambous";

        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        /// <param name="name">Nom du panda</param>
        public Panda(string name) : base(name) { }

        /// <summary>
        /// Fait crier le panda
        /// </summary>
        public override void Shout() { }
    }
}
