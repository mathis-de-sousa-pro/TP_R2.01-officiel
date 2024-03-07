using System;

namespace TP_07
{
    public class Wheel
    {
        #region attributs
        // Size of the wheel
        private int size;
        // Car the wheel belongs to
        private Car car;
        #endregion

        #region accesseurs
        /// <summary>
        /// Gets or sets the car the wheel belongs to.
        /// </summary>
        public Car Car
        {
            get => car;
            set => car = value;
        }
        #endregion

        #region constructeurs
        /// <summary>
        /// Initializes a new instance of the Wheel class with a specified size.
        /// </summary>
        /// <param name="taille">The size of the wheel.</param>
        public Wheel(int taille)
        {
            this.size = taille;
        }

        /// <summary>
        /// Initializes a new instance of the Wheel class that is a copy of the current instance.
        /// </summary>
        /// <param name="wheel">The wheel to copy.</param>
        public Wheel(Wheel wheel)
        {
            this.size = wheel.size;
        }
        #endregion

        #region méthodes
        /// <summary>
        /// Returns a string that represents the current wheel.
        /// </summary>
        /// <returns>A string that represents the current wheel.</returns>
        public override string ToString()
        {
            return "[Wheel] " + this.size.ToString() + " inches";
        }

        /// <summary>
        /// Determines whether the specified Wheel is equal to the current Wheel.
        /// </summary>
        /// <param name="other">The Wheel to compare with the current Wheel.</param>
        /// <returns>true if the specified Wheel is equal to the current Wheel; otherwise, false.</returns>
        protected bool Equals(Wheel other)
        {
            return size == other.size;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current Wheel.
        /// </summary>
        /// <param name="obj">The object to compare with the current Wheel.</param>
        /// <returns>true if the specified object is equal to the current Wheel; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Wheel) obj);
        }

        /// <summary>
        /// Serves as a hash function for a Wheel object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a hash table.</returns>
        public override int GetHashCode()
        {
            return size;
        }
        #endregion
    }
}