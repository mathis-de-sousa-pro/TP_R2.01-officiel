using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TP
{
    /// <summary>
    /// Zoo contenant des animaux
    /// </summary>
    [DataContract]
    public class Zoo
    {
        /// <summary>
        /// Animaux dans le zoo
        /// </summary>
        [DataMember]
        private List<Animal> _animals;

        /// <summary>
        /// Objet servant a creer un nouvelle animal
        /// </summary>
        [DataMember]
        private AnimalFactory _factory;

        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        public Zoo()
        {
            _animals = new List<Animal>();
            _factory = new AnimalFactory();
        }

        /// <summary>
        /// Creer un nouvelle animal et l'ajoute dans le Zoo
        /// </summary>
        /// <param name="name">Nom de l'animal</param>
        /// <param name="type">type de l'animal</param>
        public void AddAnimal(string name, string type)
        {
            Animal a = _factory.CreateAnimal(name, type);

            if (a != null)
                _animals.Add(a);
        }

        /// <summary>
        /// Retire l'animal du Zoo
        /// </summary>
        /// <param name="a">Nom de l'animal</param>
        public void RemoveAnimal(Animal a)
        {
            _animals.Remove(a);
        }

        /// <summary>
        /// Donne un Array des animaux dans le Zoo
        /// </summary>
        /// <returns>Retourne un array de type Animal</returns>
        public Animal[] ListAnimals()
        {
            return _animals.ToArray();
        }

        /// <summary>
        /// Donne la liste des especes presentent dans le Zoo
        /// </summary>
        /// <returns>Array de String contenant les especes</returns>
        public string[] ListSpecies()
        {
            return _factory.ListSpecies();
        }
    }
}
