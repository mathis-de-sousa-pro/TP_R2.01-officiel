using System;

namespace TP_07
{
    public class Driver
    {
        #region attributs
        // Name of the driver
        private string name;
        // Car the driver is driving
        private Car car;
        #endregion

        #region accesseurs
        /// <summary>
        /// Gets or sets the car the driver is driving.
        /// </summary>
        public Car Car
        {
            get => car;
            set => car = value;
        }
        #endregion

        #region constructeurs
        /// <summary>
        /// Initializes a new instance of the Driver class with a specified name.
        /// </summary>
        /// <param name="nom">The name of the driver.</param>
        public Driver(string nom)
        {
            this.name = nom;
        }

        /// <summary>
        /// Initializes a new instance of the Driver class that is a copy of the current instance.
        /// </summary>
        /// <param name="conducteur">The driver to copy.</param>
        public Driver(Driver conducteur)
        {
            this.name = conducteur.name;
            this.car = conducteur.car;
        }
        #endregion

        #region méthodes
        /// <summary>
        /// Returns a string that represents the current driver.
        /// </summary>
        /// <returns>A string that represents the current driver.</returns>
        public override string ToString()
        {
            return "[Driver] "+this.name;
        }

        /// <summary>
        /// Determines whether the specified Driver is equal to the current Driver.
        /// </summary>
        /// <param name="other">The Driver to compare with the current Driver.</param>
        /// <returns>true if the specified Driver is equal to the current Driver; otherwise, false.</returns>
        protected bool Equals(Driver other)
        {
            return name == other.name;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current Driver.
        /// </summary>
        /// <param name="obj">The object to compare with the current Driver.</param>
        /// <returns>true if the specified object is equal to the current Driver; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Driver) obj);
        }

        /// <summary>
        /// Serves as a hash function for a Driver object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a hash table.</returns>
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
        #endregion
    }
}