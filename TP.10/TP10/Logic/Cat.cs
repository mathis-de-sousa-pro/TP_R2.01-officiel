using System.Runtime.Serialization;

namespace TP
{
    /// <summary>
    /// Classe Cat, heriant de Animal
    /// </summary>
    [DataContract]
    public class Cat : Animal
    {
        /// <summary>
        /// Nourriture du chat
        /// </summary>
        public override string Food => "des souris";
        
        /// <summary>
        /// Espece du chat
        /// </summary>
        public override string Species => "chat";

        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        /// <param name="name">Nom du chat</param>
        public Cat(string name) : base(name) { }

        /// <summary>
        /// Fait crier le chat
        /// </summary>
        public override void Shout()
        {
            
        }
    }
}
