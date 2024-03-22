using TP;

namespace TP10.Logic;

/// <summary>
/// Fabrique de la classe Animal
/// </summary>
public class AnimalFactory
{
    /// <summary>
    /// Creer un nouvel Animal
    /// </summary>
    /// <param name="name">Nom de l'animal</param>
    /// <param name="type">Espece de l'animal</param>
    /// <returns>L'animal créé, ou null si le type donné est inconnu</returns>
    public Animal CreateAnimal(string name, string type)
    {
        Animal animal = null;
        switch (type.ToLower())
        {
            case "human":
                animal = new Human(name);
                break;
            case "eagle":
                animal = new Eagle(name);
                break;
            case "vulture":
                animal = new Vulture(name);
                break;
            case "cocker":
                animal = new Cocker(name);
                break;
            case "sheperd":
                animal = new Sheperd(name);
                break;
            case "cat":
                animal = new Cat(name);
                break;
        }

        return animal;
    }

    /// <summary>
    /// Donne la liste des especes possibles
    /// </summary>
    /// <returns>Array de string</returns>
    public string[] ListSpecies() => new string[] { "cocker", "eagle", "human", "sheperd", "vulture", "cat" };
}