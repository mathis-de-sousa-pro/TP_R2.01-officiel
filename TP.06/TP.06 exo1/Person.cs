using System;

namespace TP._06_exercice_1
{
    public class Person
    {
        #region Fields
        private string _lastName; //Nom de la personne
        private string _firstName; //Prénom de la personne
        #endregion

        #region Constructor
        public Person(string lastName, string firstName) //Constructeur de la classe Person qui prend en paramètre le nom et le prénom de la personne
        {
            _lastName = lastName;
            _firstName = firstName;
        }
        #endregion

        #region Methods
        public override string ToString() //Méthode pour afficher les informations du compte sous forme de chaîne de caractères
        {
            return string.Concat(_firstName, " ", _lastName);
        }
        #endregion
    }
}