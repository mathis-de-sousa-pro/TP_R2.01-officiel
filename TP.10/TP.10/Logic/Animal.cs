using System.Runtime.Serialization;

namespace TP
{
    [DataContract]
    [KnownType(typeof(Cat))]
    [KnownType(typeof(Cocker))]
    [KnownType(typeof(Eagle))]
    [KnownType(typeof(Human))]
    [KnownType(typeof(Sheperd))]
    [KnownType(typeof(Vulture))]
    public abstract class Animal
    {
        /// <summary>
        /// Le nom de l'animal
        /// </summary>
        [DataMember]
        private string _name;

        /// <summary>
        /// Le nom de l'animal
        /// </summary>
        public string Name {get => _name; set => _name = value; }

        /// <summary>
        /// Espece de l'animal
        /// </summary>
        public abstract string Species { get; }

        /// <summary>
        /// La nourriture de l'animal, doit comporter l'article devant
        /// </summary>
        public abstract string Food { get; }

        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        /// <param name="name">Nom de l'animal</param>
        public Animal(string name)
        {
            this._name = name;
        }

        /// <summary>
        /// Convertie l'instance de la classe Animal en string
        /// </summary>
        /// <returns>Son nom puis son espece, puis sa nourriture en une phrase</returns>
        public override string ToString()
        {
            return $"My name is { this.Name}, I'm a dog ({this.Species}) and I eat {this.Food}.";
        }

        /// <summary>
        /// Fait crier l'animal
        /// </summary>
        public abstract void Shout();

    }
}
