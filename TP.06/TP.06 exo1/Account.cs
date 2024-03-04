using System;

namespace TP._06_exercice_1
{
    public class Account
    {
        #region Fields
        private string _number; //Numéro de compte
        private int _balance;  //Solde du compte
        private Person _client; //Titulaire du compte
        #endregion

        #region Constructor
        public Account(Person client, string number) //Constructeur de la classe Account qui prend en paramètre le titulaire du compte et le numéro de compte
        {
            _number = number;
            _balance = 0;
            _client = client;
        }
        #endregion

        #region Methods
        public void Deposit(int sum) //Méthode pour déposer de l'argent
        {
            _balance += sum;
        }

        public void Withdraw(int amount) //Méthode pour retirer de l'argent
        {
            _balance -= amount;
        }

        public override string ToString() //Méthode pour retourner les informations du compte sous forme de chaîne de caractères
        {
            return "Account number "+_number+" – "+_client.ToString()+" - Balance : "+_balance+" euros";
        }
        #endregion
    }
}